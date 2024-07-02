using RestaurantManagement.API.Models;

namespace RestaurantManagement.API.Dtos
{
    public class ConfigDto
    {
        public List<ShiftSelectionTemplate> Templates { get; set; }
        public List<EmployeeInfoDto> Employees { get; set; }
        public DateTime CloseDate { get; set; }
        public DateTime FinalizeDate { get; set; }
    }
}
