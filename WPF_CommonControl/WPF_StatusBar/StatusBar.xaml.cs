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

namespace WPF_StatusBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StatusBar : Window
    {
        public StatusBar()
        {
            InitializeComponent();
        }

        private void TxtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetLineIndexFromCharacterIndex(row);
            lbCusorPosition.Text = "Line " + (row + 1) + ", Char " + (col + 1);
        }
    }
}
