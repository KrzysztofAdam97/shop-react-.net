using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using shop_react_.net_back.Entities;

namespace shop_react_.net_back.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(ShopContext context, UserManager<user> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new user
                {
                    UserName = "norek",
                    Email = "norek@gmail.com"
                };

                await userManager.CreateAsync(user, "Haslo#1234");
                await userManager.AddToRoleAsync(user, "Customer");

                var admin = new user
                {
                    UserName = "norekadmin",
                    Email = "norekadmin@gmail.com"
                };

                await userManager.CreateAsync(admin, "Haslo#1234");
                await userManager.AddToRolesAsync(admin, new[] {"Customer", "Admin"});
            }

            if (context.products.Any())
            {
                return;   // jeśli istnieją produkty, to zwróć, inaczej wykończ kod poniżej 
            }

            var products = new List<product>
            {
                new product
                {
                    name_product = "procesor intel core i7 8700k",
                    description_product = "procesor intel core i7 8th gen 4.2ghz najwyzsza jakość i najwyższy czas obliczeń blablabla",
                    price = 10,
                    // ImageUrl = "https://via.placeholder.com/150",
                    // Type = "nowe",
                    // Brand = "intel",
                    // // Category = "procesory",
                    in_stock = 10,
                    id_category = 2
                },
                new product
                {
                    name_product = "procesor intel core i8 8800k",
                    description_product = "procesor intel core i8 8th gen 4.2ghz najwyzsza jakość i najwyższy czas obliczeń blablabla",
                    price = 20,
                    // ImageUrl = "https://via.placeholder.com/150",
                    // Type = "nowe",
                    // Brand = "intel",
                    // // Category = "procesory",
                    in_stock = 20,
                    id_category = 2
                },
                new product
                {
                    name_product = "procesor intel core i9 8900k",
                    description_product = "procesor intel core i9 8th gen 4.2ghz najwyzsza jakość i najwyższy czas obliczeń blablabla",
                    price = 30,
                    // ImageUrl = "https://via.placeholder.com/150",
                    // Type = "nowe",
                    // Brand = "intel",
                    // // Category = "procesory",
                    in_stock = 30,
                    id_category = 2
                },
                new product
                {
                    name_product = "karta graficzna radeon rx 580",
                    description_product = "karta graficzna radeon rx 580 4gb ram 256bit najwyzsza jakość i najwyższy czas obliczeń blablabla",
                    price = 15,
                    // ImageUrl = "https://via.placeholder.com/150",
                    // Type = "nowe",
                    // Brand = "amd",
                    // // Category = "karty graficzne",
                    in_stock = 15,
                    id_category = 1
                },
                new product
                {
                    name_product = "karta graficzna radeon rx 730",
                    description_product = "karta graficzna radeon rx 730 4gb ram 256bit najwyzsza jakość i najwyższy czas obliczeń blablabla",
                    price = 30,
                    // ImageUrl = "https://via.placeholder.com/150",
                    // Type = "nowe",
                    // Brand = "amd",
                    // // Category = "karty graficzne",
                    in_stock = 30,
                    id_category = 1
                },
            };

            foreach (var product in products)
            {
                context.products.Add(product);
            }

            context.SaveChanges();
        }
    }
}
