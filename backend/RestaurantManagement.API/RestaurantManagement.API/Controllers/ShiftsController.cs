using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.API.Data;
using RestaurantManagement.API.Dtos;
using RestaurantManagement.API.Enums;
using RestaurantManagement.API.Interfaces;

namespace RestaurantManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]

    public class ShiftsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IWeekService _weekService;
        private readonly IShiftService _shiftService;
        private readonly ILogger<ShiftsController> _logger;

        public ShiftsController(DataContext context, IWeekService weekService, IShiftService shiftService, ILogger<ShiftsController> logger)
        {
            _context = context;
            _weekService = weekService;
            _shiftService = shiftService;
            _logger = logger;
        }


        // GET: api/Shifts/Employee:EmployeeID
        [HttpGet("Employee/{employeeId}/{type}")]
        public async Task<ActionResult<ShiftsUserResponseDto>> GetShiftsById(string employeeId, EmployeeType type)
        {
            _logger.LogInformation("\nGetting Shifts\n");
            var UserShiftDtos = await _shiftService.GetMonthlyShiftsByIdAsync(employeeId, type);
            _logger.LogInformation("\nFinished Getting Shifts\n");

            if (UserShiftDtos.Shifts == null || UserShiftDtos.Shifts.Count == 0)
            {
                return NotFound();
            }

            return Ok(UserShiftDtos);
        }

        //GET: api/Shifts/Submitted/:Type
        [HttpGet("Submitted/{Type}")]
        public async Task<ActionResult<List<ManagerGetShiftDto>>> GetSubmittedShiftsByType(EmployeeType Type)
        {
            _logger.LogInformation("\nGetting Submitted Shifts\n");
            var shifts = await _shiftService.GetMonthlySubmittedShiftsByTypeAsync(Type);
            _logger.LogInformation("\nFinished Getting Submitted Shifts\n");


            if (shifts == null || shifts.Count == 0)
            {
                return NotFound();
            }

            return Ok(shifts);
        }

        //GET: api/Shifts/Edited/:ManagerId
        [HttpGet("Edited/{ManagerId}/{type}")]
        public async Task<ActionResult<ManagerGetEditedShiftDto>> GetEditedShiftsByManagerId(string ManagerId, EmployeeType type)
        {
            _logger.LogInformation("\nGetting Edited Shifts\n");
            var shiftsDto = await _shiftService.GetWeeklyEditedShiftsByManagerIdAsync(ManagerId, type);
            _logger.LogInformation("\nFinished Getting Edited Shifts\n");


            if (shiftsDto.Shifts == null || shiftsDto.Shifts.Count == 0)
            {
                return NotFound();
            }

            return Ok(shiftsDto);
        }

        // PUT: api/Shifts/Employee/
        [HttpPut]
        public async Task<IActionResult> PutShiftById(ShiftsUserUpdateDto Shifts)
        {
            try
            {
                _logger.LogInformation("\napplying Changes to DB\n");
                await _shiftService.UpdateShiftsAsync(Shifts);
                _logger.LogInformation("\nChanges applied succesfully\n");

            }
            catch (DbUpdateConcurrencyException)
            {
                _logger.LogError("\nDb Did not update due to concurrenct Issues\n");
                throw; 
            }

            return NoContent();
        }

        //PUT: api/Shifts/Edited/:{EmployeeType}
        [HttpPut("Edited/{type}")]
        public async Task<IActionResult> PutEditShiftsByType([FromRoute] EmployeeType type, [FromBody] ManagerPutShiftsDto shifts)
        {
            var updateDto = new ShiftsManagerUpdateDto()
            {
                Shifts = shifts.Shifts,
                EmployeeType = type
            };

            try
            {
                _logger.LogInformation("\nApplying changes to DB\n");
                await _shiftService.ManagerEditShiftsAsync(updateDto); // Pass the DTO to your service method
                _logger.LogInformation("\nChanges applied successfully\n");
            }
            catch (DbUpdateConcurrencyException)
            {
                _logger.LogError("\nDB did not update due to concurrency issues\n");
                throw;
            }

            return NoContent();
        }


    }
}
