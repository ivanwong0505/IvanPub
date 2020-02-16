using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using IvanCafe.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IvanCafe.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PubDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PubDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if (!context.Products.Any())
            {
                var productType = new List<ProductType>
                {
                    new ProductType { Name = "Drink" },
                    new ProductType { Name = "Snack" },
                };

                new List<Product>
                {
                    new Product { Name = "Worm Catcher", ProductType = productType.Single(p => p.Name == "Drink"), Price = 2.5M, Description = "a English India Pale Ale (IPA) style beer brewed by Late Knights Brewery", ImageName = "WormCatcher.jpg", IsForSale = true},
                    new Product { Name = "Jaipur", ProductType = productType.Single(p => p.Name == "Drink"), Price = 2.59M, Description = "A English India Pale Ale (IPA) style beer brewed by Thornbridge Brewery in Bakewell. ", ImageName = "Jaipur.jpg", IsForSale = true },
                    new Product { Name = "Britannia¡¦s Brew", ProductType = productType.Single(p => p.Name == "Drink"), Price = 2.86M, Description = "A IPA - Session / India Session Ale", ImageName = "Britannia.jpg", IsForSale = true },
                    new Product { Name = "Scotch Eggs", ProductType = productType.Single(p => p.Name == "Snack"), Price = 2.99M, Description = "Hand-cooked and taste delicious", ImageName = "ScotchEgg.jpg", IsForSale = true },
                    new Product { Name = "Scampi Fries", ProductType = productType.Single(p => p.Name == "Snack"), Price = 1.99M, Description = "A delicious savoury snack, made from only the finest ingredients", ImageName = "ScampiFries.jpg", IsForSale = true },
                    new Product { Name = "Sausage Roll", ProductType = productType.Single(p=> p.Name == "Snack" ), Price = 2.99M, Description = "The perfect snack for any occasion, golden fluffy pastry wrapped with delicious sausage meat.", ImageName = "SausageRoll.jpg", IsForSale = true}
                }.ForEach(p => context.Products.AddOrUpdate(p));
                context.SaveChanges();
            }

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var user = new ApplicationUser { UserName = "admin@IvanPub.co.uk" };
                var guestUser = new ApplicationUser { UserName = "customer@IvanPub.co.uk" };

                userManager.Create(user, "admin251"); //simple password for development testing
                userManager.Create(guestUser, "pass251"); //simple password for development testing

                roleManager.Create(new IdentityRole { Name = "Admin" });
                userManager.AddToRole(user.Id, "Admin");

                context.SaveChanges();
            }
        }
    }
}
