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

    int w1 = 0;
    int w2 = 0;
    int w3 = 0;
    int w4 = 0;
    int w5 = 0;
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
        Random l = new Random();
        
        
        if (dostepna1 == true)
        {
            w1 = l.Next(1, 7);
            if(w1 == 1)
            {
                ob1.Source = new BitmapImage(new Uri("zdjecia/kosc1.png", UriKind.Relative));
            }
            if (w1 == 2)
            {
                ob1.Source = new BitmapImage(new Uri("zdjecia/kosc2.png", UriKind.Relative));
            }
            if (w1 == 3)
            {
                ob1.Source = new BitmapImage(new Uri("zdjecia/kosc3.png", UriKind.Relative));
            }
            if (w1 == 4)
            {
                ob1.Source = new BitmapImage(new Uri("zdjecia/kosc4.png", UriKind.Relative));
            }
            if (w1 == 5)
            {
                ob1.Source = new BitmapImage(new Uri("zdjecia/kosc5.png", UriKind.Relative));
            }
            if (w1 == 6)
            {
                ob1.Source = new BitmapImage(new Uri("zdjecia/kosc6.png", UriKind.Relative));
            }
        }
        if (dostepna2 == true)
        {
            w2 = l.Next(1, 7);
            if (w2 == 1)
            {
                ob2.Source = new BitmapImage(new Uri("zdjecia/kosc1.png", UriKind.Relative));
            }
            if (w2 == 2)
            {
                ob2.Source = new BitmapImage(new Uri("zdjecia/kosc2.png", UriKind.Relative));
            }
            if (w2 == 3)
            {
                ob2.Source = new BitmapImage(new Uri("zdjecia/kosc3.png", UriKind.Relative));
            }
            if (w2 == 4)
            {
                ob2.Source = new BitmapImage(new Uri("zdjecia/kosc4.png", UriKind.Relative));
            }
            if (w2 == 5)
            {
                ob2.Source = new BitmapImage(new Uri("zdjecia/kosc5.png", UriKind.Relative));
            }
            if (w2 == 6)
            {
                ob2.Source = new BitmapImage(new Uri("zdjecia/kosc6.png", UriKind.Relative));
            }
        }
        if (dostepna3 == true)
        {
            w3 = l.Next(1, 7);
            if (w3 == 1)
            {
                ob3.Source = new BitmapImage(new Uri("zdjecia/kosc1.png", UriKind.Relative));
            }
            if (w3 == 2)
            {
                ob3.Source = new BitmapImage(new Uri("zdjecia/kosc2.png", UriKind.Relative));
            }
            if (w3 == 3)
            {
                ob3.Source = new BitmapImage(new Uri("zdjecia/kosc3.png", UriKind.Relative));
            }
            if (w3 == 4)
            {
                ob3.Source = new BitmapImage(new Uri("zdjecia/kosc4.png", UriKind.Relative));
            }
            if (w3 == 5)
            {
                ob3.Source = new BitmapImage(new Uri("zdjecia/kosc5.png", UriKind.Relative));
            }
            if (w3 == 6)
            {
                ob3.Source = new BitmapImage(new Uri("zdjecia/kosc6.png", UriKind.Relative));
            }
        }
        if (dostepna4 == true)
        {
            w4 = l.Next(1, 7);
            if (w4 == 1)
            {
                ob4.Source = new BitmapImage(new Uri("zdjecia/kosc1.png", UriKind.Relative));
            }
            if (w4 == 2)
            {
                ob4.Source = new BitmapImage(new Uri("zdjecia/kosc2.png", UriKind.Relative));
            }
            if (w4 == 3)
            {
                ob4.Source = new BitmapImage(new Uri("zdjecia/kosc3.png", UriKind.Relative));
            }
            if (w4 == 4)
            {
                ob4.Source = new BitmapImage(new Uri("zdjecia/kosc4.png", UriKind.Relative));
            }
            if (w4 == 5)
            {
                ob4.Source = new BitmapImage(new Uri("zdjecia/kosc5.png", UriKind.Relative));
            }
            if (w4 == 6)
            {
                ob4.Source = new BitmapImage(new Uri("zdjecia/kosc6.png", UriKind.Relative));
            }
        }
        if (dostepna5 == true)
        {
            w5 = l.Next(1, 7);
            if (w5 == 1)
            {
                ob5.Source = new BitmapImage(new Uri("zdjecia/kosc1.png", UriKind.Relative));
            }
            if (w5 == 2)
            {
                ob5.Source = new BitmapImage(new Uri("zdjecia/kosc2.png", UriKind.Relative));
            }
            if (w5 == 3)
            {
                ob5.Source = new BitmapImage(new Uri("zdjecia/kosc3.png", UriKind.Relative));
            }
            if (w5 == 4)
            {
                ob5.Source = new BitmapImage(new Uri("zdjecia/kosc4.png", UriKind.Relative));
            }
            if (w5 == 5)
            {
                ob5.Source = new BitmapImage(new Uri("zdjecia/kosc5.png", UriKind.Relative));
            }
            if (w5 == 6)
            {
                ob5.Source = new BitmapImage(new Uri("zdjecia/kosc6.png", UriKind.Relative));
            }
        }

        int suma = (w1 + w2 + w3 + w4 + w5);
        Wynik.Text = suma.ToString();
    }
}
}
