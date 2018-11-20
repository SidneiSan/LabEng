using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Myfactory.SIT.app.Models
{
    public class LoginViewModel
    {

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o Email do usuário", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "Informe um email válido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }
    }
}