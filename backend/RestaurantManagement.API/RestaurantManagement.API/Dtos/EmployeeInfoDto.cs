using RestaurantManagement.API.Enums;

namespace RestaurantManagement.API.Dtos
{
    public class EmployeeInfoDto
    {
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
