using NuGet.Configuration;
using RestaurantManagement.API.Dtos;
using RestaurantManagement.API.Models;

namespace RestaurantManagement.API.Interfaces
{
    public interface IConfigService
    {
        Task AddShiftSelectionTemplate(ShiftSelectionDto template);
        Task DeleteShiftSelectionTemplate(int templateId);
        Task<List<ShiftSelectionDto>> GetShiftSelectionTemplates();

        Task<Tuple<DateTime, DateTime>> GetWeekSettings();
    }   
}
