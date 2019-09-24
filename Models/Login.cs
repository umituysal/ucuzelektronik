using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Kullanıcı adınız alanı boş bırakmayınız!")]
        [DisplayName("Kullanıcı Adınız")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakmayınız!")]
        [DisplayName("Şifreniz")]
         public string Password { get; set; }
        
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }

    }
}