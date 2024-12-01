using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Product
{
    public class Product
    {
        string Name { get; set; }
        double Price
        {
            get { return Price; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Цена не может быть меньше 0");
                }
                else
                {
                    Price = value;
                }
            }
        }
        int Quantity
        {
            get { return Quantity; }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Кол-во не может быть меньше 0");
                }
                else
                {
                    Quantity = value;
                }
            }
        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public Product(string name, double price) : this(name, price, 1)
        {
            Name = name;
            Price = price;

        }
        public void Deconstruct(out string name, out double price, out int quantity)
        {
            name = Name;
            price = Price;
            quantity = Quantity;
        }
    }

}
