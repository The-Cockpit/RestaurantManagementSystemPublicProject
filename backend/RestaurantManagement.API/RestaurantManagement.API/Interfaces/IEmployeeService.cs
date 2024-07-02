using RestaurantManagement.API.Dtos;
using RestaurantManagement.API.Enums;
using RestaurantManagement.API.Models;

namespace RestaurantManagement.API.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployeesAsync();

        Task<List<Employee>> GetEmployeesByTypeAsync(EmployeeType EmployeeType);
        Task <Employee> GetEmployeeByIdAsync(string EmployeeId);
        Task UpdateEmployeeType(string id, EmployeeType type);
    }
}
