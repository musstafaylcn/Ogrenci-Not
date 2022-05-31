using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Student
{
    /// <summary>
    /// Interaction logic for GecmeNotuHesapla.xaml
    /// </summary>
    public partial class GecmeNotuHesapla : Window
    {
        public GecmeNotuHesapla()
        {
            // Position window in center of the screen
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Hesapla(object sender, RoutedEventArgs e)
        {
            int vize, ortalama;
            float final;
            if(!int.TryParse(tb_vize.Text, out vize))
            {
                MessageBox.Show("This is a number only field", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(!int.TryParse(tb_ortalama.Text, out ortalama))
            {
                MessageBox.Show("This is a number only field", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(vize < 0)
            {
                MessageBox.Show("Vize sıfırdan küçük olamaz yalancı", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if(ortalama < 40)
            {
                MessageBox.Show("Ortalama 40'dan küçük olamaz", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            final = ((ortalama * 5) - (vize * 2)) / 3;
            label_final.Content = "Finalden alman gereken not: " + final.ToString();
        }

        void Window_Closing(object sender, CancelEventArgs e)
        {
            //MessageBox.Show("Closing called");
            MainWindow window_main = new MainWindow();
            window_main.Show();
            //this.Close();
        }
    }
}
