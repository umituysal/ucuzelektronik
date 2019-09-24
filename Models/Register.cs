 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Adınız alanı boş bırakmayınız!")]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadınız alanı boş bırakmayınız!")]
        [DisplayName("Soyadınız")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Kullanıcı adınız alanı boş bırakmayınız!")]
        [DisplayName("Kullanıcı Adınız")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email adresi alanı boş bırakmayınız!")]
        [EmailAddress(ErrorMessage="Email Adresinizi düzgün giriniz")]
        [DisplayName("Email Adresiniz")]
        public string Email { get; set; }
      
        [Required(ErrorMessage = "Şifreniz alanı boş bırakmayınız!")]
        [DisplayName("Şifreniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı boş bırakmayınız!")]
        [DisplayName("Şifrenizi Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreniz uyuşmuyor.Tekrar Deneyiniz!")]
        public string RePassword { get; set; }

    }
}