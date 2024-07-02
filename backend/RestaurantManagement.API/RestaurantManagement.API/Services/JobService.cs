using Hangfire;
using RestaurantManagement.API.Interfaces;

namespace RestaurantManagement.API.Services
{
    public class JobService : IJobService
    {
        private readonly IShiftService _shiftService;
        public JobService(IShiftService shiftService)
        {

            _shiftService = shiftService;

        }

        public void RunWeekClosingRecurringJob() => RecurringJob.AddOrUpdate("CloseWeek", () => _shiftService.CloseShifts(), "0 12 * * 3");
        public void RunWeekFinalizingRecurringJob() => RecurringJob.AddOrUpdate("FinalizeWeek", () => _shiftService.FinalizeShifts(), "0 12 * * 5");


    }
}
