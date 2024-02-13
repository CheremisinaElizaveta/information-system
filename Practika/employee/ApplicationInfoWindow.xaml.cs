using Practika.TehSupportDataSetTableAdapters;
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

namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для ApplicationInfoWindow.xaml
    /// </summary>
    public partial class ApplicationInfoWindow : Window
    {
        Status_TableAdapter status_TableAdapter = new Status_TableAdapter();
        public ApplicationInfoWindow()
        {
            InitializeComponent();
            ApplicationInfoW.ItemsSource = status_TableAdapter.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationCreateWindow acw = new ApplicationCreateWindow();
            acw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PartsWindow pw = new PartsWindow();
            pw.Show(); 
        }
    }
}
