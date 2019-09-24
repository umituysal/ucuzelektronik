using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() { Name="Kamera" , Description="Kamera Ürünleri" },
                new Category() { Name="Bilgisayar" , Description="Bilgisayar Ürünleri" },
                new Category() { Name="Elektronik" , Description="Elektronik Ürünleri" },
                new Category() { Name="Telefon" , Description="Telefon Ürünleri"},
                new Category() { Name="Beyaz Eşya" , Description="Beyaz Eşya Ürünleri" },
            };

            foreach (var item in kategoriler)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();


            var urunler = new List<Product>()
            {
                new Product() {Name="Itallian Pizza", Description="DSLR ile öne çıkmanızı sağlayan basit hikaye anlatımı", Price=3.90, Stock=5, IsApproved=true ,CategoryId=1 ,IsHome = true ,Image="kamera.jpg" },
                new Product() {Name="Canon Eos 200D 18-55Mm 24.2Mp 3.0", Description="DSLR ile öne çıkmanızı sağlayan basit hikaye anlatımı", Price=1200, Stock=5, IsApproved=true ,CategoryId=1 ,Image="kamera2.jpg" },
                new Product() {Name="Canon Eos 1200D 18-55 mm DC Profesyonel Dijital Fotoğraf Makinesi", Description="DSLR ile öne çıkmanızı sağlayan basit hikaye anlatımı", Price=1200, Stock=5, IsApproved=true ,CategoryId=1 ,IsHome = true ,Image="kamera3.jpg" },

                new Product() {Name="HP 15-RA012NT", Description="Bağlı kalmanız ve günlük görevlerinizin üstesinden gelmeniz için yaratılmış şık bir dizüstü bilgisayarla gücünüzü gün boyu koruyun. Güvenilir performans ve uzun dayanan pil ömrüyleh1 internette kolayca dolaşabilir, içerik izleyebilir ve önem verdiklerinizle bağlı kalabilirsiniz.", Price=4000, Stock=52, IsApproved=true ,CategoryId=2 ,IsHome = true ,Image="bilgisayar1.jpg"  },
                new Product() {Name="Dell Gaming G315", Description="Bağlı kalmanız ve günlük görevlerinizin üstesinden gelmeniz için yaratılmış şık bir dizüstü bilgisayarla gücünüzü gün boyu koruyun. Güvenilir performans ve uzun dayanan pil ömrüyleh1 internette kolayca dolaşabilir, içerik izleyebilir ve önem verdiklerinizle bağlı kalabilirsiniz.", Price=1200, Stock=5, IsApproved=true ,CategoryId=2 ,IsHome = true ,Image="bilgisayar2.jpg"  },
                new Product() {Name="HP Pavilion Gaming", Description="Bağlı kalmanız ve günlük görevlerinizin üstesinden gelmeniz için yaratılmış şık bir dizüstü bilgisayarla gücünüzü gün boyu koruyun. Güvenilir performans ve uzun dayanan pil ömrüyleh1 internette kolayca dolaşabilir, içerik izleyebilir ve önem verdiklerinizle bağlı kalabilirsiniz.", Price=1200, Stock=5, IsApproved=true ,CategoryId=2 ,IsHome = true ,Image="bilgisayar3.jpg" },

                new Product() {Name="Sinbo SCM-2943 Elektrikli Cezve", Description="Kaliteli paslanmaz çelik gövdesi ile yüksek malzeme kalitesine sahip ve uzun ömürlüdür.", Price=1200, Stock=5, IsApproved=true ,CategoryId=3 ,IsHome = true ,Image="kahve1.jpg"  },
                new Product() {Name="Fakir Kaave Türk Kahve Makinası – Kahverengi", Description="DSLR ile öne çıkmanızı sağlayan basit hikaye anlatımı", Price=1200, Stock=5, IsApproved=true ,CategoryId=3 ,IsHome = true ,Image="kahve2.jpg" },
                new Product() {Name="Arçelik K-3190P Telve Türk Kahve Makinesi", Description="DSLR ile öne çıkmanızı sağlayan basit hikaye anlatımı", Price=1200, Stock=5, IsApproved=true ,CategoryId=3 ,IsHome = true ,Image="kahve3.jpg" },

                new Product() {Name="Xiomi Mi8", Description="DSLR ile öne çıkmanızı sağlayan basit hikaye anlatımı", Price=1200, Stock=5, IsApproved=true ,CategoryId=4 ,IsHome = true ,Image="telefon1.jpg" },
                new Product() {Name="Iphone S7", Description="DSLR ile öne çıkmanızı sağlayan basit hikaye anlatımı", Price=1200, Stock=5, IsApproved=true ,CategoryId=4 ,IsHome = true ,Image="telefon2.jpg" },
                new Product() {Name="Samsung Se8", Description="DSLR ile öne çıkmanızı sağlayan basit hikaye anlatımı", Price=1200, Stock=5, IsApproved=true ,CategoryId=4 ,IsHome = true ,Image="telefon3.jpg" },
 
                new Product() {Name="Arçelik Bulaşık Makinasi", Description="DSLR ile öne çıkmanızı sağlayan basit hikaye anlatımı", Price=1200, Stock=5, IsApproved=true ,CategoryId=5 ,IsHome = true ,Image="bulasik.jpg" },
                new Product() {Name="Samsung Çamaşır Makinası", Description="DSLR ile öne çıkmanızı sağlayan basit hikaye anlatımı", Price=1200, Stock=5, IsApproved=true ,CategoryId=5 ,IsHome = true ,Image="camasir.jpg" },
                new Product() {Name="Beko Buzdolabı Makinası", Description="DSLR ile öne çıkmanızı sağlayan basit hikaye anlatımı", Price=1200, Stock=5, IsApproved=true ,CategoryId=5 ,IsHome = true ,Image="buzdolabi.jpg" }

            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();
        }
    }
}
