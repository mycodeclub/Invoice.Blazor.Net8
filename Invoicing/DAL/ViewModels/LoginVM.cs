using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Invoicing.DAL.ViewModels
{
    public class LoginVM
    {
        [Required]
        [Display(Name = "Login Name")]
        public string LoginName { get; set; }

        [Required]
        public string Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
