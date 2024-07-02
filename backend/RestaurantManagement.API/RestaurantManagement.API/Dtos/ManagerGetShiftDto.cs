using RestaurantManagement.API.Enums;

namespace RestaurantManagement.API.Dtos
{
    public class ManagerGetShiftDto
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public EmployeeType Type { get; set; }
        public string? EmployeeId { get; set; }
    }
}
