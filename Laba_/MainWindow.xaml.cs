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

namespace Laba_
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            BD bh, current;
            int d, m, y;
            try
            {
                d = Convert.ToInt32(days.Text);
                m = Convert.ToInt32(months.Text);
                y = Convert.ToInt32(years.Text);
                bh = new BD(d, m, y);
                current = new BD();
                den_data.Content = current.days_print();
                Mis_data.Content = current.months_print();
                rik_data.Content = current.years_print();
                Vik.Content = bh.Age();
                Dni.Content = bh.Days();
                Mis.Content = bh.Mounths();
                zagal.Content = bh.FullAge();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
