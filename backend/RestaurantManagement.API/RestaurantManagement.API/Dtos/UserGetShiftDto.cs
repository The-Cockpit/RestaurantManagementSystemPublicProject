using RestaurantManagement.API.Enums;

namespace RestaurantManagement.API.Dtos
{
    public class UserGetShiftDto
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsTicked { get; set; }
        public EmployeeType Type { get; set; }
        public ShiftStatus Status { get; set; }
        public string? EmployeeId { get; set; }
    }

}
