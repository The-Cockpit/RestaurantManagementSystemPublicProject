using RestaurantManagement.API.Dtos;
using RestaurantManagement.API.Enums;
using RestaurantManagement.API.Models;

namespace RestaurantManagement.API.Interfaces
{
    public interface IShiftService
    {
        Task UpdateShiftsAsync(ShiftsUserUpdateDto shifts);
        Task<ShiftsUserResponseDto> GetMonthlyShiftsByIdAsync(string Employeeid, EmployeeType type);
        Task<List<ManagerGetShiftDto>> GetMonthlySubmittedShiftsByTypeAsync(EmployeeType type);
        Task<ManagerGetEditedShiftDto> GetWeeklyEditedShiftsByManagerIdAsync(string ManagerId, EmployeeType type);
        Task ManagerEditShiftsAsync(ShiftsManagerUpdateDto shifts);
        Task CloseShifts();
        Task FinalizeShifts();
        Task<List<ShiftSelectionTemplate>> GetConfigTemplateShifts();
    }
}
