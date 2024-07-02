using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using RestaurantManagement.API.Data;
using RestaurantManagement.API.Dtos;
using RestaurantManagement.API.Enums;
using RestaurantManagement.API.Interfaces;
using RestaurantManagement.API.Models;
using RestaurantManagement.API.Services;
using System.Globalization;

namespace RestaurantManagement.API.Services
{
    //TODO: create mediator service to communicate between shift and week service so i can put the closeweek and finalize week in the mediator
    public class ShiftService : IShiftService
    {
        
        private readonly DataContext _context;
        private readonly IWeekService _weekService;
        private readonly ILogger<ShiftService> _logger;


        public ShiftService(DataContext context, IWeekService weekService, ILogger<ShiftService> logger)
        {
            _context = context;
            _weekService = weekService;
            _logger = logger;
        }
        public async Task<ManagerGetEditedShiftDto> GetWeeklyEditedShiftsByManagerIdAsync(string ManagerId, EmployeeType type)
        {

            // Fetch the required weeks 
            Week week = await _weekService.GetNextWeekAsync();

            if (week == null)
            {
                _logger.LogWarning("\nError in GetMonthlyEditedShiftsByTypeAsync: Week is null\n");
                return new ManagerGetEditedShiftDto();
            } 

            // Get all the shifts that match the criteria from the fetched weeks
            List<Shift> submittedShifts = new List<Shift>();
            List<Shift> EditedShifts = new List<Shift>();

            // Fetch all employees once to avoid multiple database queries
            var employeeIds = _context.Employees.Select(s => s.Id).Distinct().ToList();

            var employees = await _context.Employees
                .Where(e => employeeIds.Contains(e.Id))
                .ToListAsync();


            // Create a dictionary for quick lookup of employee details by ID
            var employeeDict = employees.ToDictionary(e => e.Id, e => e);

            if (!employeeDict[ManagerId].IsManager)
            {
                _logger.LogWarning("\nERROR: Provided employee is not a manager\n");
                return new ManagerGetEditedShiftDto();
            }

            //find managertype



            if (week.WeekStatus == WeekStatus.Open)
            {
                submittedShifts.AddRange(week.Shifts
                    .Where(shift => shift.Type == type && shift.Status == ShiftStatus.Submitted && shift.IsTicked == true)
                    .ToList());
            }

            EditedShifts.AddRange(week.Shifts
                .Where(shift => shift.Type == type && shift.Status == ShiftStatus.EditedByManager)
                .ToList());

            
            ////filter shifts
            //if (EditedShifts.Count != 0 && week.WeekStatus != WeekStatus.Finalized)
            //{
            //    submittedShifts = submittedShifts
            //        .Where(submittedShift =>
            //            !EditedShifts.Any(EditedShift =>
            //                DoesOverlap(EditedShift, submittedShift)
            //            )
            //        )
            //        .ToList();
            //}

            //create a dto to return
            List<Shift> shiftsResult = [.. submittedShifts, .. EditedShifts];
            

            var resultDto = shiftsResult.Select(shift => new ManagerGetShiftDto
            {
                Id = shift.ID,
                Subject = employeeDict.ContainsKey(shift.EmployeeId) ? employeeDict[shift.EmployeeId].FullName : "Unknown",
                Description = shift.Description,
                StartTime = shift.StartHour,
                EndTime = shift.EndHour,
                Type = shift.Type,
                EmployeeId = shift.EmployeeId
            }).ToList();


            var result = new ManagerGetEditedShiftDto()
            {
                Shifts = resultDto,
                WeekState = week.WeekStatus
            };

            return result;
  
        }
        public async Task<List<ManagerGetShiftDto>> GetMonthlySubmittedShiftsByTypeAsync(EmployeeType type)
        {
            // Fetch the required weeks 
            List<Week> weeks = await _weekService.GetMonthAsync();

            // Get all the shifts that match the criteria from the fetched weeks
            List<Shift> submittedShifts = new List<Shift>();
            foreach (var week in weeks)
            {
                var shifts = week.Shifts
                    .Where(shift => shift.Type == type && shift.Status == ShiftStatus.Submitted && shift.IsTicked == true)
                    .ToList();

                submittedShifts.AddRange(shifts);
            }

            // Fetch all employees once to avoid multiple database queries
            var employeeIds = submittedShifts.Select(s => s.EmployeeId).Distinct().ToList();
            var employees = await _context.Employees
                .Where(e => employeeIds.Contains(e.Id))
                .ToListAsync();

            // Create a dictionary for quick lookup of employee details by ID
            var employeeDict = employees.ToDictionary(e => e.Id, e => e);

            // Convert the shifts to ManagerGetSubmittedShiftsDto
            var submittedShiftsDtos = submittedShifts.Select(shift => new ManagerGetShiftDto
            {
                Id = shift.ID,
                Subject = employeeDict.ContainsKey(shift.EmployeeId) ? employeeDict[shift.EmployeeId].FullName : "Unknown",
                Description = shift.Description,
                StartTime = shift.StartHour,
                EndTime = shift.EndHour,
                Type = shift.Type,
                EmployeeId = shift.EmployeeId
            }).ToList();

            return submittedShiftsDtos;
        }
        public async Task<List<ShiftSelectionTemplate>> GetConfigTemplateShifts()
        {
            try
            {
                //var templateConfigShifts = await _context.Shifts
                //   .Where(s => s.Status == ShiftStatus.ConfigTemplate)
                //   .ToListAsync();
                //return templateConfigShifts;
                return new List<ShiftSelectionTemplate>();
            }
           
             catch (Exception ex)
            {
                _logger.LogError(ex, "\nAn error occurred while fetching template config shifts.\n");
                return new List<ShiftSelectionTemplate>();
            }
        }
        public async Task<ShiftsUserResponseDto> GetMonthlyShiftsByIdAsync(string id, EmployeeType type)
        {
            List<Week> weeks = await _weekService.GetMonthAsync();

            bool isFinalized = true;
            List<Shift> shifts = new List<Shift>();
            List<Shift> SubmittedShifts = new List<Shift>();
            List<Shift> TemplateShifts = new List<Shift>();

            foreach (var week in weeks)
            {
                // Filter SubmittedShifts for the employee
                SubmittedShifts = week.Shifts
                    .Where(shift => (shift.EmployeeId == id || shift.EmployeeId == null) && shift.Status == Enums.ShiftStatus.Submitted && shift.IsTicked == true && shift.Type == type)
                    .ToList();

                // Determine if any week is not finalized
                if (week.WeekStatus == WeekStatus.Open)
                {
                    isFinalized = false;
                    // Filter ShiftTemplates based on SubmittedShifts overlap
                    var templateShifts = week.Shifts?
                        .Where(templateShift => templateShift.Status == ShiftStatus.template && templateShift.Type == type)
                        .ToList();

                    if (SubmittedShifts.Count != 0)
                    {
                        templateShifts = templateShifts?
                            .Where(templateShift =>
                                !SubmittedShifts.Any(submittedShift =>
                                    DoesOverlap(submittedShift, templateShift)
                                )
                            )
                            .ToList();
                    }
                    // Add filtered SubmittedShifts and ShiftsTemplate to shifts list
                    shifts.AddRange(SubmittedShifts ?? Enumerable.Empty<Shift>());
                    shifts.AddRange(templateShifts ?? Enumerable.Empty<Shift>());
                }
                else if (week.WeekStatus == WeekStatus.Closed)
                    shifts.AddRange(SubmittedShifts ?? Enumerable.Empty<Shift>());

                else
                {
                    // Add all FinalizedShifts if week is finalized
                    shifts.AddRange(week.Shifts?
                        .Where(shift =>  shift.EmployeeId != null && shift.Status == Enums.ShiftStatus.Finalized && shift.Type == type)
                        .ToList() ?? Enumerable.Empty<Shift>());
                }


            }

            // Convert the shifts to UserGetShiftDto
            var UserGetShiftDtos = shifts.Select(shift => new UserGetShiftDto
            {
                Id = shift.ID,
                Subject = shift.Subject,
                Description = shift.Description,
                StartTime = shift.StartHour,
                EndTime = shift.EndHour,
                IsTicked = shift.IsTicked,
                Type = shift.Type,
                Status = shift.Status,
                EmployeeId = shift.EmployeeId
            }).ToList();

            ShiftsUserResponseDto response = new ShiftsUserResponseDto()
            {
                Shifts = UserGetShiftDtos,
                IsFinalized = isFinalized
            };
            return response;
        }
        public async Task UpdateConfigTemplateShifts() { }
        public async Task UpdateShiftsAsync(ShiftsUserUpdateDto shifts)
        {
            var shiftsToUpdate = new List<Shift>();
            if(shifts.ShiftIds != null && shifts.ShiftIds.Count != 0)
            {
                 shiftsToUpdate = await _context.Shifts
                    .Where(s => shifts.ShiftIds.Contains(s.ID))
                    .ToListAsync();
            }
  

            var clonedShifts = new List<Shift>();
            var shiftsToRemove = new List<Shift>();
            Week nextWeek = await _weekService.GetNextWeekAsync();
            
            if (nextWeek.WeekStatus == WeekStatus.Closed)
            {
                _logger.LogInformation("\nERROR: Week is closed for submitting\n");
                return;
            }

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    foreach (Shift shift in shiftsToUpdate)
                    {
                        Shift clonedShift = CloneShift(shift, nextWeek, ShiftStatus.Submitted);
                        clonedShift.EmployeeId = shifts.EmployeeID;
                        clonedShifts.Add(clonedShift);

                        if (shift.Status != ShiftStatus.template)
                            shiftsToRemove.Add(shift);
                    }

                    foreach (var shift in nextWeek.Shifts)
                    {
                        if (!shiftsToUpdate.Contains(shift) && shift.EmployeeId == shifts.EmployeeID)
                            shift.IsTicked = false;
                    }
                    foreach (var shift in shiftsToRemove)
                    {
                        nextWeek.Shifts.Remove(shift);
                        _context.Entry(shift).State = EntityState.Deleted;
                    }
                    foreach (var shift in clonedShifts)
                    {
                        nextWeek.Shifts.Add(shift);
                    }
               
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    // Log the exception
                    _logger.LogInformation(ex.Message);
                    await HandleConcurrencyExceptionAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogWarning(ex.Message);
                    await transaction.RollbackAsync();
                    return;
                }
            }
            
        }
        public async Task ManagerEditShiftsAsync(ShiftsManagerUpdateDto shiftsDto)
        {
            if (shiftsDto == null || shiftsDto.Shifts == null)
            {
                _logger.LogWarning("\nERROR: Shifts DTO or its Shifts property cannot be null\n");
                return;
            }

            Week nextWeek = await _weekService.GetNextWeekAsync();

            if (nextWeek.WeekStatus == WeekStatus.Open)
            {
                _logger.LogWarning("\nERROR: Week is closed for editing\n");
                return;
            }

            // Check if some edited shifts need deleting
            var shiftIds = shiftsDto.Shifts.Select(s => s.Id).ToList();

            var shiftsToRemove = await _context.Shifts
                .Where(shift => shiftIds.Contains(shift.ID) && shift.Status == ShiftStatus.EditedByManager)
                .ToListAsync();


            var clonedShifts = new List<Shift>();

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    foreach (var shift in shiftsToRemove)
                    {
                        nextWeek.Shifts.Remove(shift);
                        _context.Entry(shift).State = EntityState.Deleted;
                    }

                    foreach (var shiftDto in shiftsDto.Shifts)
                    {
                        if(shiftDto.EmployeeId == null || shiftDto.Type == null || shiftDto.Subject == null || shiftDto.StartTime == null || shiftDto.EndTime == null)
                        {
                            _logger.LogWarning("\nERROR: shift was not created because one of the parameters sent is null\n");
                            continue;
                        }
                        if(shiftDto.StartTime > shiftDto.EndTime)
                        {
                            _logger.LogWarning($"\n SHIFT WITH ID {shiftDto.Id} START TIME IS BIGGER THEN ITS END TIME!! \n");
                            continue;
                        }

                        var newShift = CreateShiftFromDto(new ShiftsCreateDto
                        {
                            StartTime = shiftDto.StartTime,
                            EndTime = shiftDto.EndTime,
                            Subject = shiftDto.Subject,
                            Type = shiftDto.Type,
                            EmployeeId = shiftDto.EmployeeId,
                            WeekId = nextWeek.ID,
                        });
                        newShift.Description = shiftDto.Description;
                        clonedShifts.Add(newShift);
                    }

                    nextWeek.Shifts.AddRange(clonedShifts);

                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    _logger.LogWarning(ex, "\nConcurrency exception occurred while saving shifts\n");
                    await HandleConcurrencyExceptionAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "\nAn error occurred while updating shifts\n");
                    await transaction.RollbackAsync();
                    return;
                }
            }
        }
        public async Task CloseShifts()
        {
            Week nextWeek = await _weekService.GetNextWeekAsync();

            var shiftsToClone = nextWeek.Shifts
                .Where(s => s.Status == ShiftStatus.Submitted)
                .ToList();

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    List<Shift> clonedShifts = new List<Shift>();
                    foreach (var shift in shiftsToClone)
                    {
                        Shift newShift = CloneShift(shift, nextWeek, ShiftStatus.EditedByManager);
                        newShift.Description = "";
                        clonedShifts.Add(newShift);
                        
                    }
                    nextWeek.Shifts.AddRange(clonedShifts);

                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    _logger.LogWarning(ex, "\nConcurrency exception occurred while closing shifts\n");
                    await HandleConcurrencyExceptionAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "\nAn error occurred while updating shifts\n");
                    await transaction.RollbackAsync();
                }
            }
        }
        public async Task FinalizeShifts()
        {
            Week nextWeek = await _weekService.GetNextWeekAsync();

            var shiftsToFinalize = nextWeek.Shifts
               .Where(s => s.Status == ShiftStatus.EditedByManager)
               .ToList();

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    List<Shift> clonedShifts = new List<Shift>();
                    foreach (var shift in shiftsToFinalize)
                    {
                        Shift clonedShift = CloneShift(shift, nextWeek, ShiftStatus.Finalized);
                        clonedShift.Description = "";
                        clonedShifts.Add(clonedShift);
                    }
                    nextWeek.Shifts.AddRange(clonedShifts);

                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    _logger.LogWarning(ex, "\nConcurrency exception occurred while closing shifts\n");
                    await HandleConcurrencyExceptionAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "\nAn error occurred while updating shifts\n");
                    await transaction.RollbackAsync();
                }
            }
        }
        public async Task HandleConcurrencyExceptionAsync()
        {
            var retryDelay = TimeSpan.FromSeconds(0.5);
            const int maxRetries = 3;

            for (int i = 0; i < maxRetries; i++)
            {
                try
                {
                    await Task.Delay(retryDelay);
                    await _context.SaveChangesAsync();
                    return;
                }
                catch (DbUpdateConcurrencyException retryEx)
                {
                    _logger.LogWarning(retryEx, $"\nRetry {i + 1}/{maxRetries} failed due to concurrency exception\n");
                    retryDelay += TimeSpan.FromSeconds(0.5); // Exponential backoff
                }
            }

            throw new InvalidOperationException("\nUnable to update shifts due to a concurrency conflict.\n");
        }
        private Shift CloneShift(Shift shift, Week week, ShiftStatus status) 
        {
            if (week == null)
                throw new Exception();

            Shift clonedShift = new Shift
            {
                Subject = shift.Subject,
                Description = shift.Description,
                StartHour = shift.StartHour,
                EndHour = shift.EndHour,
                IsTicked = true,
                Type = shift.Type,
                WeekId = week.ID,
                Status = status
            };

            return clonedShift;
        }
        private bool DoesOverlap(Shift Shift1, Shift Shift2) => 
            !(Shift1.EndHour <= Shift2.StartHour || Shift1.StartHour >= Shift2.EndHour);
        private Shift CreateShiftFromDto(ShiftsCreateDto ShiftCreateDto)
        {
            string comment = "";
           
            Shift Shift = new Shift
            {
                Description = "",
                Subject = ShiftCreateDto.Subject,
                StartHour = ShiftCreateDto.StartTime,
                EndHour = ShiftCreateDto.EndTime,
                IsTicked = true,
                Type = ShiftCreateDto.Type,
                EmployeeId = ShiftCreateDto.EmployeeId,
                WeekId = ShiftCreateDto.WeekId,
                Status = Enums.ShiftStatus.EditedByManager
            };
            return Shift;
        }

        // Converts a UI datetime string to a DateTime object
        private DateTime FormatToDb(string uiDateTime)
        {
            string format = "yyyy-MM-ddTHH:mm:ss";
            if (DateTime.TryParseExact(uiDateTime, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDateTime))
            {
                return parsedDateTime;
            }
            else
            {
                throw new FormatException("\nThe provided date string is not in the correct format.\n");
            }
        }

        // Converts a DateTime object to a UI datetime string
        private string FormatToUi(DateTime dbDateTime) => dbDateTime.ToString("yyyy-MM-ddTHH:mm:ss");

    }
    
    
}

