using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Product
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Product> Products { get; set; }
        public MainWindow()
        {
            InitializeComponent();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameBox.Text) || string.IsNullOrEmpty(PriceBox.Text) || string.IsNullOrEmpty(QuanBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
            if (string.IsNullOrEmpty(QuanBox.Text))
            {
                Products.Add(new Product(NameBox.Text, Convert.ToDouble(PriceBox.Text)));
            }
            else
            {
                Products.Add(new Product(NameBox.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(QuanBox.Text)));
            }

        }
    }
}
