using Hangfire;

namespace RestaurantManagement.API.Interfaces
{
    public interface IJobService
    {
        void RunWeekClosingRecurringJob();
        void RunWeekFinalizingRecurringJob();
    }
}
