using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.API.Data;
using RestaurantManagement.API.Dtos;
using RestaurantManagement.API.Enums;
using RestaurantManagement.API.Interfaces;
using RestaurantManagement.API.Models;
using RestaurantManagement.API.Services;
using System.Web.Http.Cors;

namespace RestaurantManagement.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]

    public class ManagersController : ControllerBase
    {

        private readonly DataContext _context;
        private readonly ILogger<ShiftsController> _logger;
        private readonly IEmployeeService _employeeService;
        private readonly IShiftService _shiftService;
        private readonly IConfigService _configService;
        public ManagersController(DataContext context, ILogger<ShiftsController> logger, IEmployeeService employeeService, IShiftService shiftService, IConfigService configService)
        {
            _context = context;
            _logger = logger;
            _employeeService = employeeService;
            _shiftService = shiftService;
            _configService = configService;
        }

        // GET: api/Managers/GetEmployees
        [HttpGet("GetEmployees")]
        public async Task<ActionResult<List<EmployeeInfoDto>>> GetEmployees()
        {
            _logger.LogInformation("\nGetting Employees\n");
            var employees = await _employeeService.GetEmployeesAsync();
            _logger.LogInformation("\nFinished Getting Employees\n");

            var employeesDto = employees.Select(employee =>
            {
                var names = employee.FullName?.Split(' ');
                var firstName = names?.FirstOrDefault() ?? "";
                var lastName = names?.Length > 1 ? string.Join(" ", names.Skip(1)) : "";

                return new EmployeeInfoDto
                {
                    EmployeeId = employee.Id,
                    FirstName = firstName,
                    LastName = lastName,
                    EmployeeType = employee.Type,
                };
            }).ToList();

            return Ok(employeesDto);
        }

        // GET: api/Managers/GetEmployees/:Type
        [HttpGet("GetEmployees/{type}")]
        public async Task<ActionResult<List<EmployeeInfoDto>>> GetEmployees([FromRoute] EmployeeType type)
        {
            _logger.LogInformation("\nGetting Employees\n");
            var employees = await _employeeService.GetEmployeesByTypeAsync(type);
            _logger.LogInformation("\nFinished Getting Employees\n");

            var employeesDto = employees.Select(employee =>
            {
                var names = employee.FullName?.Split(' ');
                var firstName = names?.FirstOrDefault() ?? "";
                var lastName = names?.Length > 1 ? string.Join(" ", names.Skip(1)) : "";

                return new EmployeeInfoDto
                {
                    EmployeeId = employee.Id,
                    FirstName = firstName,
                    LastName = lastName,
                    EmployeeType = employee.Type,
                };
            }).ToList();

            return Ok(employeesDto);
        }

        //GET: api/Managers/WeekSettings
        [HttpGet("WeekSettings")]
        public async Task<ActionResult<(DateTime, DateTime)>> GetWeekSettings()
        {
            Tuple<DateTime,DateTime> Settings = await _configService.GetWeekSettings();
            if (Settings == null)
            {
                _logger.LogError("\nERROR FETCHING WEEK SETTINGS\n");
                return NoContent();
            }
            return (Settings.Item1, Settings.Item2);

        }

        //GET: api/Managers/ShiftSelectionTemplate
        [HttpGet("ShiftSelectionTemplate")]
        public async Task<ActionResult<List<ShiftSelectionDto>>> GetShiftSelectionTemplates()
        {
            List<ShiftSelectionDto> shiftSelectionDtos = await _configService.GetShiftSelectionTemplates();

            return Ok(shiftSelectionDtos);
        }

        //PUT: api/Managers/UpdateEmployeeType
        [HttpPut("UpdateEmployeeType/{Id}")]
        public async Task<IActionResult> UpdateEmployeeType([FromRoute] string Id, [FromBody] EmployeeType Type)
        {
            if(Id == null)
            {
                _logger.LogWarning("\n NO ID WAS PROVIDED\n");
                return NoContent();
            }
            if (Type == null)
            {
                _logger.LogWarning("\n NO TYPE WAS PROVIDED\n");
                return NoContent();
            }
            try
            {
                await _employeeService.UpdateEmployeeType(Id, Type);
            }
            catch (Exception ex)
            {
                _logger.LogWarning("\nError Updating Employee Type");
            }
            return NoContent();
        }

        //POST: api/Managers/ShiftSelectionTemplate
        [HttpPost("ShiftSelectionTemplate")]
        public async Task<IActionResult> AddShiftSelectionTemplate(ShiftSelectionDto template)
        {
            if(template == null)
            {
                _logger.LogWarning("\n WARNING: NO TEMPLATE PROVIDED\n");
                return NoContent();
            }
            await _configService.AddShiftSelectionTemplate(template);
            return NoContent();
        }

        //DELETE: api/Managers/ShiftSelectionTemplate
        [HttpDelete("ShiftSelectionTemplate")]
        public async Task<IActionResult> DeleteShiftSelectionTemplate(int templateId)
        {
            if (templateId == null)
            {
                _logger.LogWarning("\n WARNING: NO NAME PROVIDED\n");
                return NoContent();
            }
            await _configService.DeleteShiftSelectionTemplate(templateId);
            return NoContent();
        }




        ////GET: api/Managers/GetConfig
        //[HttpGet("GetConfig/{type}")]
        //public async Task<ActionResult<ConfigDto>> GetConfig(EmployeeType type)
        //{
        //    _logger.LogInformation("\nGetting Config\n");

        //    var configModel = await _context.Configs.FirstOrDefaultAsync();

        //    if (configModel == null)
        //    {
        //        _logger.LogWarning("\nConfig not found.\n");
        //        return NotFound("Config not found.");
        //    }

        //    ConfigDto config = new ConfigDto();

        //    // Gather info
        //    List<Employee> employeesByType = await _employeeService.GetEmployeeByTypeAsync(type);
        //    var employeesDto = employeesByType.Select(employee =>
        //    {
        //        var names = employee.FullName?.Split(' ');
        //        var firstName = names?.FirstOrDefault() ?? "";
        //        var lastName = names?.Length > 1 ? string.Join(" ", names.Skip(1)) : "";

        //        return new EmployeeInfoDto
        //        {
        //            EmployeeId = employee.Id,
        //            FirstName = firstName,
        //            LastName = lastName,
        //            EmployeeType = employee.Type,
        //        };
        //    }).ToList();

        //    config.Templates = await _shiftService.GetConfigTemplateShifts();
        //    config.CloseDate = configModel.CloseDate;
        //    config.FinalizeDate = configModel.FinalizeDate;
        //    config.Employees = employeesDto;

        //    _logger.LogInformation("\nFinished Getting Config\n");

        //    return Ok(config);
        //}

        ////PUT: api/Managers/UpdateConfig
        //[HttpPut("UpdateConfig")]
        //public async Task<ActionResult<ConfigDto>> UpdateConfig(ConfigDto Config)
        //{

        //    return NoContent();
        //}

        //POST: api/Managers/ShiftSelectionTemplate
    }
}
