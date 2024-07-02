using RestaurantManagement.API.Dtos;

namespace RestaurantManagement.API.Models
{
    public class Config
    {
        public int ID { get; set; }
        public DateTime CloseDate { get; set; }
        public DateTime FinalizeDate { get; set; }
        public List<ShiftSelectionTemplate> ShiftSelectionTemplates { get; set; }
    }
}
