using System.ComponentModel.DataAnnotations;

namespace shop_react_.net_back.Entities
{
    public class basket_item
    {
        [Key]
        public int id_basket_item { get; set; }
        public int quantity { get; set; }

        // navigation properties - zwracające referencje do innych encj z bazy danych

        public int id_product { get; set; }
        public product product { get; set; }
    }
}