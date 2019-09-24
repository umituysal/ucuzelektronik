﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı adınızı giriniz.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen adres tanımınızı giriniz.")]
        public string AdresBasligi { get; set; }
        [Required(ErrorMessage = "Lütfen bir adres giriniz.")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen bir şehir giriniz.")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen bir semt giriniz.")]
        public string Semt { get; set; }
        [Required(ErrorMessage = "Lütfen bir mahalle giriniz.")]
        public string Mahalle { get; set; }
        [Required(ErrorMessage = "Lütfen bir posta kodu giriniz.")]
        public string PostaKodu { get; set; }
    }
}