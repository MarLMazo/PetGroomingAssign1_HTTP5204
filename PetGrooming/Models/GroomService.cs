using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomService
    {
        /*
            A GroomService is a type of activity that a Groomer can do for a pet. Some examples might be nail clipping, shampoo, trim, etc.
            
            Some things that describe a GroomService
                - Service Name
                - Cost
                - Duration
         */
         [Key]
        public int GroomServiceID { get; set; }
        public string GroomServiceName { get; set; }
        public double GroomServicePrice { get; set; }
        public int GroomServiceDuration { get; set; }
        //Duration should be in terms of minutes only
        //Services duration also only have 15mins, 30mins, 45mins, 60mins and so on
        //in viewing duration, convert it to hours example: 90mins will be 1hour and 30minutes
       
    }
}