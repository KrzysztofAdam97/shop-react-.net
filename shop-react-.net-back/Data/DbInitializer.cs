using System;
using System.Collections.Generic;
using System.Linq;
using shop_react_.net_back.Entities;

namespace shop_react_.net_back.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            if (context.Products.Any())
            {
                return;
            }

            var products = new List<Product>
            {
                new Product
                {
                    Name = "procesor intel core i7 8700k",
                    Description = "procesor intel core i7 8th gen 4.2ghz najwyzsza jakość i najwyższy czas obliczeń blablabla",
                    Price = 10,
                    ImageUrl = "https://via.placeholder.com/150",
                    Type = "nowe",
                    Brand = "intel",
                    Category = "procesory",
                    InStock = 10
                },
                new Product
                {
                    Name = "procesor intel core i8 8800k",
                    Description = "procesor intel core i8 8th gen 4.2ghz najwyzsza jakość i najwyższy czas obliczeń blablabla",
                    Price = 20,
                    ImageUrl = "https://via.placeholder.com/150",
                    Type = "nowe",
                    Brand = "intel",
                    Category = "procesory",
                    InStock = 20
                },
                new Product
                {
                    Name = "procesor intel core i9 8900k",
                    Description = "procesor intel core i9 8th gen 4.2ghz najwyzsza jakość i najwyższy czas obliczeń blablabla",
                    Price = 30,
                    ImageUrl = "https://via.placeholder.com/150",
                    Type = "nowe",
                    Brand = "intel",
                    Category = "procesory",
                    InStock = 30
                },
                new Product
                {
                    Name = "karta graficzna radeon rx 580",
                    Description = "karta graficzna radeon rx 580 4gb ram 256bit najwyzsza jakość i najwyższy czas obliczeń blablabla",
                    Price = 15,
                    ImageUrl = "https://via.placeholder.com/150",
                    Type = "nowe",
                    Brand = "amd",
                    Category = "karty graficzne",
                    InStock = 15
                },
                new Product
                {
                    Name = "karta graficzna radeon rx 730",
                    Description = "karta graficzna radeon rx 730 4gb ram 256bit najwyzsza jakość i najwyższy czas obliczeń blablabla",
                    Price = 30,
                    ImageUrl = "https://via.placeholder.com/150",
                    Type = "nowe",
                    Brand = "amd",
                    Category = "karty graficzne",
                    InStock = 30
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}
