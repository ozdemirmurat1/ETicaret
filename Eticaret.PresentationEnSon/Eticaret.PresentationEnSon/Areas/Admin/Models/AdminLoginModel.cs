﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.Areas.Admin.Models
{
    public class AdminLoginModel
    {
        // Data Annotation
        [Required(ErrorMessage = "Email Boş Bırakılamaz."), MaxLength(30, ErrorMessage = "30 Karakterden uzun email olamaz imkansız.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^(([^<>()[\]\\.,;:\s@""]+(\.[^<>()[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "Hatalı Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre Giriniz.")]
        public string Password { get; set; }
    }
}
