using Microsoft.AspNetCore.Identity;
using RestaurantManagement.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.API.Models
{
    public class Employee : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public EmployeeType Type { get; set; }
        [Required]
        // public EmployeeType ManagerType { get; set; }
        public bool IsManager { get; set; }
        public virtual ICollection<Shift>? Shifts { get; set; }
    }

}
