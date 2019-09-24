using Abc.MvcWebUI.Entity;
using Abc.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using PagedList;
namespace Abc.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index(string currentFilter, int? page)
        {
            //List<Product> products = _context.Products.ToList();
            //PagedList<Product> model = new PagedList<Product>(products, page, pageSize);
            var product = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 40) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 40) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                }).ToList();


            int pageSize = 6;
            int pageNumber = (page ?? 1);


            return View(product.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }
        public ActionResult List(int? id, string q, string sortOrder, string currentFilter, int? page)
        {

            var product = _context.Products
                .Where(i => i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "1.jpg",
                    CategoryId = i.CategoryId
                }).AsQueryable();
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "category";


            if (q != null)
            {
                page = 1;
            }
            else
            {
                q = currentFilter;
            }

            ViewBag.CurrentFilter = q;

            //Burada urunler üzerine bir daha sorgu yazabilmek için asqueryable kullanıldı.?? iki soru işareti ternary operator anlamında kullanılmıştır
            if (string.IsNullOrEmpty(q) == false)
            {
                product = product.Where(i => i.Name.Contains(q) || i.Description.Contains(q));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    product = product.OrderByDescending(s => s.Name);
                    break;
                case "category":
                    product = product.OrderBy(s => s.Category);
                    break;
                case "date_desc":
                    product = product.OrderByDescending(s => s.Stock);
                    break;
                default:
                    product = product.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
           
   
            if (id != null)
            {
                product = product.Where(i => i.CategoryId == id);
            }


            return View(product.ToPagedList(pageNumber, pageSize));
        }
        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
        public ActionResult About()
        {
            var about = _context.Abouts.FirstOrDefault();

            return View(about);
        }
        public ActionResult Contact()
        {
            var contact = _context.Contacts.FirstOrDefault();

            return View(contact);
        }
        [HttpPost]
        public ActionResult Contact(EpostaModel model)
        {
            if (ModelState.IsValid)
            {
                string server = ConfigurationManager.AppSettings["server"];
                int port = int.Parse(ConfigurationManager.AppSettings["port"]);
                bool ssl = ConfigurationManager.AppSettings["ssl"].ToString() == "1" ? true : false;

                string from = ConfigurationManager.AppSettings["from"];
                string password = ConfigurationManager.AppSettings["password"];
                string fromname = ConfigurationManager.AppSettings["fromname"];
                string to = ConfigurationManager.AppSettings["to"];


                var client = new SmtpClient();
                client.Host = server;
                client.Port = port;
                client.EnableSsl = ssl;
                client.UseDefaultCredentials = true;
                client.Credentials = new System.Net.NetworkCredential(from, password);


                var email = new MailMessage();
                email.From = new MailAddress(from, fromname);
                email.To.Add(to);

                email.Subject = model.Subject;
                email.IsBodyHtml = true;
                email.Body = $"Adınız Soyadınız :{model.Name} \n Konu: {model.Subject} \n Mesaj :{model.Message} \n Eposta : {model.Email}";
                try
                {
                    client.Send(email);
                    ViewData["result"] = "Mesajınız Gönderilmiştir.En kısa zamanda geri dönüş yapılacaktır.";
                }
                catch (Exception)
                {
                    ViewData["result"] = "Mesajınız Gönderilemedi.Tekrar Deneyin.";
                    throw;
                }
              
            }

            return View(model);
        }
    }
}