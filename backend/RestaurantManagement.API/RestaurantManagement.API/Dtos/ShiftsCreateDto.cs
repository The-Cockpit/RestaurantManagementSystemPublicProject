using RestaurantManagement.API.Enums;

namespace RestaurantManagement.API.Dtos
{
    public class ShiftsCreateDto
    {
        public EmployeeType Type { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Subject { get; set; }
        public string EmployeeId { get; set; }
        public int WeekId { get; set; }
    }
}


////Publish manager shifts
//public EmployeeId 
//public EmployeeType Type { get; set; }
//public DateTime StartHour { get; set; }
//public DateTime EndHour { get; set; }