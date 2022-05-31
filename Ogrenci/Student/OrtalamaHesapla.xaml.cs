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
using System.Windows.Shapes;

namespace Student
{
    /// <summary>
    /// Interaction logic for OrtalamaHesapla.xaml
    /// </summary>
    public partial class OrtalamaHesapla : Window
    {
        public OrtalamaHesapla()
        {
            // Position window in center of the screen
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void hesapla(object sender, RoutedEventArgs e)
        {
            int vize, final;
            float ortalama;
            if(!int.TryParse(tb_vize.Text, out vize))
            {
                MessageBox.Show("This is a number only field", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(!int.TryParse(tb_final.Text, out final))
            {
                MessageBox.Show("This is a number only field", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(vize < 0 || final < 0)
            {
                MessageBox.Show("Sınav sıfırdan düşük olamaz", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            ortalama = ((vize * 2) + (final * 3)) / 5;
            label_ortalama.Content = "Ortalama : " + ortalama.ToString();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow window_main = new MainWindow();
            window_main.Show();
        }
    }
}
