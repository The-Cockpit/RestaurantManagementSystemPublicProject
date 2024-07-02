using RestaurantManagement.API.Enums;

namespace RestaurantManagement.API.Dtos
{
    public class ManagerPutShiftsDto
    {
        public List<ManagerGetShiftDto> Shifts { get; set; }
    }
}
