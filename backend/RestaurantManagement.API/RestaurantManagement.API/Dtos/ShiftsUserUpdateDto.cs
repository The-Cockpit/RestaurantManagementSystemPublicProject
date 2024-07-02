namespace RestaurantManagement.API.Dtos
{
    public class ShiftsUserUpdateDto
    {
        public string EmployeeID { get; set; }
        public List<int> ShiftIds { get; set; }

    }

}
