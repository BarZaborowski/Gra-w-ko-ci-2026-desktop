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

namespace Gra_w_kości_2026_desktop
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool dostepna1 = true;
        bool dostepna2 = true;
        bool dostepna3 = true;
        bool dostepna4 = true;
        bool dostepna5 = true;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void kosc1_Click(object sender, RoutedEventArgs e)
        {
            if(dostepna1 == true)
            {
                dostepna1 = false;
                kosc1.Opacity = 0.5;
            }
            else
            {
                dostepna1 = true;
                kosc1.Opacity = 1;
            }
        }

        private void kosc2_Click(object sender, RoutedEventArgs e)
        {
            if (dostepna2 == true)
            {
                dostepna2 = false;
                kosc2.Opacity = 0.5;
            }
            else
            {
                dostepna2 = true;
                kosc2.Opacity = 1;
            }
        }

        private void kosc3_Click(object sender, RoutedEventArgs e)
        {
            if (dostepna3 == true)
            {
                dostepna3 = false;
                kosc3.Opacity = 0.5;
            }
            else
            {
                dostepna3 = true;
                kosc3.Opacity = 1;
            }
        }

        private void kosc4_Click(object sender, RoutedEventArgs e)
        {
            if (dostepna4 == true)
            {
                dostepna4 = false;
                kosc4.Opacity = 0.5;
            }
            else
            {
                dostepna4 = true;
                kosc4.Opacity = 1;
            }
        }

        private void kosc5_Click(object sender, RoutedEventArgs e)
        {
            if (dostepna5 == true)
            {
                dostepna5 = false;
                kosc5.Opacity = 0.5;
            }
            else
            {
                dostepna5 = true;
                kosc5.Opacity = 1;
            }
        }

        private void przycisk_Click(object sender, RoutedEventArgs e)
        {
            Random l1 = new Random();
            Random l2 = new Random();
            Random l3 = new Random();
            Random l4 = new Random();
            Random l5 = new Random();
            int w1 = 0;
            int w2 = 0;
            int w3 = 0;
            int w4 = 0;
            int w5 = 0;
            if (dostepna1 == true)
            {
                w1 = l1.Next(1, 7);
                
            }
            if (dostepna2 == true)
            {
                w2 = l2.Next(1, 7);
            }
            if (dostepna3 == true)
            {
                w3 = l3.Next(1, 7);
            }
            if (dostepna4 == true)
            {
                w4 = l4.Next(1, 7);
            }
            if (dostepna5 == true)
            {
                w5 = l5.Next(1, 7);
            }

            int suma = (w1 + w2 + w3 + w4 + w5);
            Wynik.Text = suma.ToString();
        }
    }
}
