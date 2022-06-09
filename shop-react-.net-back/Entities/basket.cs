using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shop_react_.net_back.Entities
{
    public class basket
    {
        [Key]
        public int id_basket { get; set; }
        public string id_client { get; set; }
        public List<basket_item> Items { get; set; } = new();  //new List<BasketItem>();


        public void AddItem(product product, int quantity)
        {

            if (Items.All(item => item.id_product != product.id_product))
            {
                Items.Add(new basket_item {product = product, quantity = quantity});
            }

            var existingItem = Items.FirstOrDefault(item => item.id_product == product.id_product);

            if (existingItem != null)
            {
                existingItem.quantity += quantity;
            }
            // else
            // {
            //     var item = Items.First(item => item.id_product == product.id_product);
            //     item.quantity += quantity;
            // }
        }


        public void RemoveItem(int product_id, int quantity)  // tu może być problem z product_id - wystarczy zmienić na id_product
        {
            var item = Items.FirstOrDefault(item => item.id_product == product_id); // tu może być problem z product_id - wystarczy zmienić na id_product
            if (item == null) 
            {
                return;
            }
            item.quantity -= quantity;
            if (item.quantity == 0)
            {
                Items.Remove(item);
            }
            // var existingItem = Items.FirstOrDefault(item => item.id_product == product.id_product);

            // if (existingItem != null)
            // {
            //     existingItem.quantity -= quantity;
            //     if (existingItem.quantity <= 0)
            //     {
            //         Items.Remove(existingItem);
            //     }
            // }
        } 
        // var item = Items.FirstOrDefault(x => x.product.id_product == product.id_product);
        // if (item == null)
        // {
        //     Items.Add(new basket_item { product = product, quantity = quantity });
        // }
        // else
        // {
        //     item.quantity += quantity;
        // }
        

    }
}