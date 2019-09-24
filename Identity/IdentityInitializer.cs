using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {

            //Rolleri
            if (!context.Roles.Any(i=>i.Name =="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole {Name = "admin", Description = "admin rolü" };

                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole { Name = "user", Description = "user rolü" };

                manager.Create(role);
            }
            if (!context.Users.Any(i => i.Name == "memet"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser{Name = "Ümit", Surname = "uysal",UserName = "Umit", Email = "umituysal48@hotmail.com"};

                manager.Create(user, "umituysalU@123.");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }
            if (!context.Users.Any(i => i.Name == "zeki"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { Name = "hasan", Surname = "yıldız", UserName = "zeki", Email = "hasan@hotmail.com" };

                manager.Create(user, "umituysal12345.");
                manager.AddToRole(user.Id, "user");
            }


            base.Seed(context); 
        }
    }
}