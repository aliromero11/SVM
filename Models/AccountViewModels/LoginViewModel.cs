using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SVM.Models.AccountViewModels
{
    public class LoginViewModel
    {
        //[Required(ErrorMessage="El campo Correo electrónico no es una dirección de correo electrónico válida.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required]
        [Display(Name="User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password { get; set; }

        [Display(Name = "¿Recuérdame?")]
        public bool RememberMe { get; set; }
    }
}
