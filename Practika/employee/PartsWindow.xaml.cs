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
    /// Логика взаимодействия для PartsWindow.xaml
    /// </summary>
    public partial class PartsWindow : Window
    {

        partTableAdapter ptaa = new partTableAdapter();
        public PartsWindow()
        {
            InitializeComponent();
            PartsDataGrid.ItemsSource = ptaa.GetData(); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ApplicationInfoWindow aiw = new ApplicationInfoWindow();    
            aiw.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           ApplicationCreateWindow acw = new ApplicationCreateWindow();
           acw.Show();
        }
    }
}
