﻿using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz!")]
        public string userName { get; set; }


        [Required(ErrorMessage = "Lütfen mail giriniz!")]
        public string mail { get; set; }


        [Required(ErrorMessage = "Lütfen şifreyi giriniz!")]
        public string password { get; set; }


        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz!")]
        [Compare("password",ErrorMessage ="Şifreler aynı değil, kontrol edin!")]
        public string passwordConfirm { get; set; }

    }
}
