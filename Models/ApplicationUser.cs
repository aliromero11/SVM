using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SVM.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        
         
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int DNI { get; set; }
        public DateTime FecNac { get; set; } 

    }
}
