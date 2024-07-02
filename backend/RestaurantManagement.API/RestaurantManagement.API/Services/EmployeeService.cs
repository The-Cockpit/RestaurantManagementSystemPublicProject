using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using RestaurantManagement.API.Data;
using RestaurantManagement.API.Enums;
using RestaurantManagement.API.Interfaces;
using RestaurantManagement.API.Models;

namespace RestaurantManagement.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _context;
        private readonly ILogger<EmployeeService> _logger;
        public EmployeeService(DataContext context, ILogger<EmployeeService> logger)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<Employee> GetEmployeeByIdAsync(string employeeId)
        {
            if (string.IsNullOrWhiteSpace(employeeId))
            {
                _logger.LogWarning("Employee ID is null or empty.");
                return null;
            }

            return await _context.Employees
                                 .FirstOrDefaultAsync(e => e.Id == employeeId);
        }
        public async Task<List<Employee>> GetEmployeesByTypeAsync(EmployeeType EmployeeType) 
            => await _context.Employees.Where(e => (e.Type & EmployeeType) == EmployeeType).ToListAsync();

        public async Task<List<Employee>> GetEmployeesAsync() => await _context.Employees.ToListAsync();

        public async Task UpdateEmployeeType(string id, EmployeeType type)
        {
            Employee employee = await _context.Employees
                .Where(e => e.Id == id)
                .FirstOrDefaultAsync();

            if(employee == null)
            {
                _logger.LogWarning($"\n EMPLOYEE WITH ID OF {id} DOES NOT EXIST\n");
                return;
            }
            employee.Type = type;
            try
            {
                _context.Entry(employee).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                _logger.LogInformation($"\n {employee.FullName}'S TYPE WAS CHANGED TO {type}\n");
            }
            catch (Exception ex)
            {
                _logger.LogError($"\n ERROR UPDATING EMPLOYEE TYPE: {ex.Message}\n");
            }
        }
    }
}
