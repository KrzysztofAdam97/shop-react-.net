using System;
using System.ComponentModel.DataAnnotations;

namespace shop_react_.net_back.Entities
{
    public class product
    {
        [Key]
        public int id_product { get; set; }
        public string name_product { get; set; }
        public string description_product { get; set; }
        public decimal price { get; set; } // long/decimal/int?

    //     warn: Microsoft.EntityFrameworkCore.Model.Validation[30000]
    //   No type was specified for the decimal property 'price' on entity type 'product'.
    // This will cause values to be silently truncated if they do not fit in the default precision and scale.
    // Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating'
    // using 'HasColumnType()', specify precision and scale using 'HasPrecision()'
    // or configure a value converter using 'HasConversion()'.

        // public string ImageUrl { get; set; }
        // public string Type { get; set; } // nowe/uzywane/open_box?
        // public string Brand { get; set; }
        public int in_stock { get; set; } // stan magazynowy ilość produktów w magazynie
        public int id_category { get; set; } // klucz obcy ?
    }
}
