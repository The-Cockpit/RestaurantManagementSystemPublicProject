using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using RestaurantManagement.API.Data;
using RestaurantManagement.API.Enums;
using RestaurantManagement.API.Interfaces;
using RestaurantManagement.API.Models;
using static RestaurantManagement.API.Services.WeekService;

namespace RestaurantManagement.API.Services
{
    public class WeekService : IWeekService
    {
        private readonly DataContext _context;
        private readonly ILogger<WeekService> _logger;

        public WeekService(DataContext context, ILogger<WeekService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<Week>> GetMonthAsync()
        {
            DateTime today = DateTime.Today;
            DateTime startOfCurrentWeek = today.AddDays(-(int)today.DayOfWeek);
            DateTime startOfNextWeek = startOfCurrentWeek.AddDays(7);
            DateTime startOfPreviousWeek = startOfCurrentWeek.AddDays(-7);

            var weeks = await _context.Weeks
                 .Include(w => w.Shifts)
                 .Where(w => w.StartDate == startOfPreviousWeek || w.StartDate == startOfCurrentWeek || w.StartDate == startOfNextWeek)
                 .ToListAsync();

            if (weeks == null || weeks.Count == 0)
            {
                _logger.LogInformation("\nERROR: fetching weeks from db failed in function GetMonthAsync\n");
                throw new InvalidOperationException("weeks do not exist in the database.");
            }

            return weeks;
        }

        public async Task<Week> GetNextWeekAsync()
        {
            DateTime today = DateTime.Today;
            DateTime startOfCurrentWeek = today.AddDays(-(int)today.DayOfWeek);
            DateTime startOfNextWeek = startOfCurrentWeek.AddDays(7);

            var week = _context.Weeks
                .Include(w => w.Shifts)
                .Where(w => w.StartDate == startOfNextWeek).ToList();

            var nextWeek = week.FirstOrDefault();

            if (nextWeek == null)
            {
                _logger.LogInformation("\nERROR: Next week does not exist in db\n");
                throw new InvalidOperationException("Next week does not exist in the database.");
            }
            return nextWeek;

        }

        private async Task CreateWeek()
        {
            DateTime today = DateTime.Today;
            DateTime startOfCurrentWeek = today.AddDays(-(int)today.DayOfWeek);
            DateTime startOfNewWeek = startOfCurrentWeek.AddDays(14);

            await Task.Run(() =>
            {
                Week newWeek = new Week()
                {
                    StartDate = startOfNewWeek,
                    EndDate = startOfNewWeek.AddDays(7),
                    WeekStatus = WeekStatus.Open,
                    WeeklyComment = "",
                };
            });
        }


       
    }
}
