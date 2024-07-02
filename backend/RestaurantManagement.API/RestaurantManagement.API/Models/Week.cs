using RestaurantManagement.API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.API.Models
{
    public class Week
    {
        public int ID { get; set; }
        public string? WeeklyComment { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
        public WeekStatus WeekStatus { get; set; }

        [ConcurrencyCheck]
        public byte[] RowVersion { get; set; }

        public virtual ICollection<Shift>? Shifts { get; set; } = new List<Shift>();



    }
}