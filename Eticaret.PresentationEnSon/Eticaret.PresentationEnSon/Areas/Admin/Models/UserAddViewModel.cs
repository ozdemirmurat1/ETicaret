using Eticaret.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.Areas.Admin.Models
{
    public class UserAddViewModel
    {
        public int Id { get; set; }   // editlenen kullanıcının ID'si bilinmelidir.
        [Required(ErrorMessage ="Email Giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Giriniz")]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
