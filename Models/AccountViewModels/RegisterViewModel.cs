using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SVM.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage="El campo Correo electrónico no es una dirección de correo electrónico válida.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name="Nombre")]
        [Required]
        public string UserName { get; set; }

        [Required(ErrorMessage="El campo Contraseña es obligatorio.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Telefono")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage="El campo Apellido es obligatorio.")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage="El campo Direccion es obligatorio.")]
        [Display(Name = "Direccion")]
        public string Direccion{get;set;}
        [Required(ErrorMessage="El campo de Fecha de Nacimiento es obligatorio.")]
        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FecNac { get; set; }

        [Required(ErrorMessage="El campo DNI es obligatorio.")]
        [Display(Name = "DNI")] 
        public int DNI { get; set; } 

    }
}
