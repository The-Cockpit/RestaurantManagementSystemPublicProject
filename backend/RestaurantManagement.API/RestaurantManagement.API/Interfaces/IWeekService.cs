using RestaurantManagement.API.Models;

namespace RestaurantManagement.API.Interfaces
{
    public interface IWeekService
    {
        Task<List<Week>> GetMonthAsync();
        Task<Week> GetNextWeekAsync();
    }
}
