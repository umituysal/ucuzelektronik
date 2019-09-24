using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abc.MvcWebUI.Entity
{
    public class About
    {
        public int Id { get; set; }
   [AllowHtml]
        [DisplayName("Başlık")]
        public string Title { get; set; }
  
        [DisplayName("Açıklama")]
        public string Description { get; set; }
    }
}