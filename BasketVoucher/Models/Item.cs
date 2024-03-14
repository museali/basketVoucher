using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketVoucher.Models
{
    public class Item {
        //items in a basket
        public string Name { get; }
        public decimal Price { get; }
        public int Quantity { get; }

        public Item(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
