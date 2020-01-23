using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Groomer
    {
        /* 
            A groomer is someone who is employed to groom pets
            Some things that describe a groomer
                - First Name
                - Last Name
                - Date of Birth
                - Phone Number
                - Hourly Rate

            A booking must reference to a groomer
        */
        [Key]
        public int GroomerID { get; set; }
        public string GroomerFname { get; set; }
        public string GroomerLname { get; set; }
        public double GroomerRate { get; set; }
        public string GroomerSpeciality { get; set; }
        public int GroomerPhone { get; set; }
        public string GroomerAvailability { get; set; }
        //Availability is applicable only for set of days such as, Monday,Tuesday and so on.
        //Time is not included
    }
}