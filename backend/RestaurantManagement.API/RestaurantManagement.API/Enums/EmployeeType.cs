namespace RestaurantManagement.API.Enums
{
    [Flags]
    public enum EmployeeType
    {
        None = 0,
        Cook = 1,
        Waiter = 2,
        Bartender = 4,
        Hostess = 8,
        ShiftManager = 16
    }

}
