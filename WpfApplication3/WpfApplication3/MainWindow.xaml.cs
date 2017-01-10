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

namespace WpfApplication3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Koszyk zakupy;
        public MainWindow()
        {
            InitializeComponent();
            zakupy = new Koszyk();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            zakupy.SkopiujOstatni();
            label.Content = "Skopiowano ostatni element";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            zakupy.Wydrukuj();
            label.Content = "Wydrukowano paragon";
        }
    }
}
