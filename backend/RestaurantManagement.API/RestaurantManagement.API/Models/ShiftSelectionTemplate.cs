namespace RestaurantManagement.API.Models
{
    public class ShiftSelectionTemplate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StartHour { get; set; }
        public int StartMin { get; set; }
        public int EndHour { get; set; }
        public int EndMin { get; set; }
        public int? ConfigID { get; set; }
        public Config? Config { get; set; }
    }
}
