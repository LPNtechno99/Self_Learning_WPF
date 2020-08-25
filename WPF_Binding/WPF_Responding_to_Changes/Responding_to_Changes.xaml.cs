using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace WPF_Responding_to_Changes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Responding_to_Changes : Window
    {
        private ObservableCollection<User> user = new ObservableCollection<User>();
        public Responding_to_Changes()
        {
            InitializeComponent();

            user.Add(new User() { Name = "Marine" });
            user.Add(new User() { Name = "Catile" });

            lbUser.ItemsSource = user;
        }
        public class User : INotifyPropertyChanged
        {
            private string name;
            public string Name
            {
                get { return this.name; }
                set
                {
                    if (this.name != value)
                    {
                        this.name = value;
                        this.NotifyPropertyChanged("Name");
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void NotifyPropertyChanged(string propName)
            {
                if (this.PropertyChanged != null)
                    this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        private void BtnAddUser_Click(object sender, RoutedEventArgs e)
        {
            user.Add(new User() { Name = "New User" });
        }

        private void BtnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUser.SelectedItem != null)
                (lbUser.SelectedItem as User).Name = "Random Name";
        }

        private void BtnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUser.SelectedItem != null)
                user.Remove(lbUser.SelectedItem as User);
        }
    }
}
