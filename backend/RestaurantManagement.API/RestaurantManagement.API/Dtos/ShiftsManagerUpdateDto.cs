using RestaurantManagement.API.Enums;

namespace RestaurantManagement.API.Dtos
{
    public class ShiftsManagerUpdateDto
    {
        public List<ManagerGetShiftDto> Shifts {  get; set; }

        public EmployeeType EmployeeType { get; set; }
    }
}
