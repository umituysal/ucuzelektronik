using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class EpostaModel
    {
        [Required(ErrorMessage = "Adınız alanı boş bırakmayınız!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email alanı boş bırakmayınız!")]
        [EmailAddress(ErrorMessage = "Email Adresinizi düzgün giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Konu alanı boş bırakmayınız!")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Mesaj alanı boş bırakmayınız!")]
        public string Message { get; set; }

    }
}