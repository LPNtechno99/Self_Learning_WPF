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

namespace WPF_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ListView_1 : Window
    {
        public ListView_1()
        {
            InitializeComponent();

            List<User> items = new List<User>();
            items.Add(new User() { Name = "Marine", Age = 0, Mail = "Marine20@gmail.com" });
            items.Add(new User() { Name = "NamCatile", Age = 27, Mail = "NamCatile@gmail.com" });
            items.Add(new User() { Name = "MyHaNguyen", Age = 21, Mail = "MyHaNguyen99@gmail.com" });
            lvDataBinding.ItemsSource = items;
        }
    }
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        //public override string ToString()
        //{
        //    return this.Name + ", " + this.Age + " year old";
        //}

    }
}
