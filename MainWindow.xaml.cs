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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliRGB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte red, green, blue;
            red = Convert.ToByte(sliRed.Value);
            green = Convert.ToByte(sliGreen.Value);
            blue = Convert.ToByte(sliBlue.Value);
            rct_rectangle.Fill = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }

        private void btnSave_click(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            string szinadatok = $"{Convert.ToByte(sliRed.Value)};{Convert.ToByte(sliGreen.Value)};{Convert.ToByte(sliBlue.Value)}";
            lbszinek.Items.Add(szinadatok);
        }
        private void btnRemove_Click(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (lbszinek.SelectedIndex >= 0)
            {
                lbszinek.Items.RemoveAt(lbszinek.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem a listából!");
            }
        }
        
        private void btnClear_Click(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbszinek.Items.Clear();
        }
    }
}
