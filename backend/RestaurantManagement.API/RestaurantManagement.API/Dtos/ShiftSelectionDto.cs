namespace RestaurantManagement.API.Dtos
{
    public class ShiftSelectionDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int StartHour { get; set; }
        public int StartMin { get; set; }
        public int EndHour { get; set; }
        public int EndMin { get; set; }
    }
}
