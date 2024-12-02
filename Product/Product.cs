using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Diagnostics;
using System.Xml.Linq;

namespace Product
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; } 

        public Item(string name, double price, int quantity)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Название не может быть пустым");
            if (price < 0) throw new ArgumentException("Цена не может быть отрицательной", nameof(price));
            if (quantity < 0) throw new ArgumentException("Количество не может быть отрицательным", nameof(quantity));
            Price = price;
            Quantity = quantity;
        }
        public Item(string name, double price) : this(name, price, 1) { }
        public void Deconstruct(out string name, out double price, out int quantity)
        {
            name = Name;
            price = Price;
            quantity = Quantity;
        }

    }
}
