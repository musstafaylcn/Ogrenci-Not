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

namespace Student
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Position window in center of the screen
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void GecmeNotuHesapla(object sender, RoutedEventArgs e)
        {
            GecmeNotuHesapla window_gecmeNotuHesapla = new GecmeNotuHesapla();
            window_gecmeNotuHesapla.Show();
            this.Close();
        }

        private void ortalamaHesapla(object sender, RoutedEventArgs e)
        {
            OrtalamaHesapla window_ortalamaHesapla = new OrtalamaHesapla();
            window_ortalamaHesapla.Show();
            this.Close();
        }
    }
}
