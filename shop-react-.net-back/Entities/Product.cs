using System;

namespace shop_react_.net_back.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; } // long/decimal/int?
        public string ImageUrl { get; set; }
        public string Type { get; set; } // nowe/uzywane/open_box?
        public string Brand { get; set; }
        public string Category { get; set; }
        public int InStock { get; set; } // stan magazynowy ilość produktów w magazynie
    }
}
