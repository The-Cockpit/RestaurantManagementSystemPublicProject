using RestaurantManagement.API.Enums;
using RestaurantManagement.API.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.API.Models
{
    public class Shift
    {
        public int ID { get; set; }

        public string? Subject { get; set; }

        public string? Description { get; set; }

        [Required]
        public DateTime StartHour { get; set; }

        [Required]
        public DateTime EndHour { get; set; }

        public bool IsTicked { get; set; }

        [Required]
        public EmployeeType Type { get; set; } // Enum for Type

        public ShiftStatus Status { get; set; }

        public string? EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }

        public int? WeekId { get; set; }
        public virtual Week? Week { get; set; }

    }
}


/*
 * 1.0
// EmployeeId - (List<shift>, IsFinalized)
//Get 3 weeks for user AVI -> NATAN
//  SHIFT  
//    int ID 
//    string? Description 
//    DateTime StartHour (formatted)
//    DateTime EndHour (formatted)
//    bool readonly 
//    bool IsTicked
//    EmployeeType Type(int)  // Enum for Type
//    int? EmployeeId
//    int? WeekId

1.1
//Put Shift List 
//    int EmployeeID 
//    List<ShiftId> shiftIds


2.0
Route Submitted by type
Get Submitted shifts
    ManagerId - List<shift>
//  SHIFT  
//    int ID 
//    string? Subject (EmployeeName) 
//    string? Description (UserComment) 
//    DateTime StartTime (formatted)
//    DateTime EndTime (formatted)
//    EmployeeType Type(int)  // Enum for Type
//    int? EmployeeId


3.0 
Get Edited/Submited shifts
    ManagerId - (List<shift>, IsFinalized)
//  SHIFT
//    int ID 
//    string? Subject (EmployeeName) 
//    string? Description (UserComment) 
//    DateTime StartTime (formatted)
//    DateTime EndTime (formatted)
//    EmployeeType Type(int)  // Enum for Type
//    int? EmployeeId


3.1
Put Edited shifts
    List(Shifts)
//  SHIFT
//    int ID 
//    string? Subject (EmployeeName) 
//    string? Description (Comment) 
//    DateTime StartTime (formatted)
//    DateTime EndTime (formatted)
//    EmployeeType Type(int)  // Enum for Type
//    int? EmployeeId
    
*Finalized - delete all Comments







//RoadMap
//1.User - Shift submit process(GET)/ front + back
//1.1 -  Shift submit process(Put)/ front + back
//2.Manager - View Submited shifts/ front + back
//3.Manager - Edit shifts / front
//3.Manager - Finalize / Back
//4.Manager - configure Settings / Front + Back
//5.Polishing

//extras:
//Auth - identity + Google auth
//Google calander publish
//Identity authrize and types 
//log system 




//Route Put (CloseWeek)
*/