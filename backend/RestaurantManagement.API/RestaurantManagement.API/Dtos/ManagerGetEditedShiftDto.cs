using RestaurantManagement.API.Enums;

namespace RestaurantManagement.API.Dtos
{
    public class ManagerGetEditedShiftDto
    {
        public List<ManagerGetShiftDto> Shifts { get; set; }
        public WeekStatus WeekState { get; set; }
    }
}
