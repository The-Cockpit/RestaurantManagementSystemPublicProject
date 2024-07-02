using RestaurantManagement.API.Models;

namespace RestaurantManagement.API.Dtos
{
    public class ShiftsUserResponseDto
    {
        public List<UserGetShiftDto> Shifts { get; set; }
        public bool IsFinalized { get; set; }
    }
}
