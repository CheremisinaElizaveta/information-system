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
using Practika.TehSupportDataSetTableAdapters;
namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для ApplicationInfoWindowRemont.xaml
    /// </summary>
    public partial class ApplicationInfoWindowRemont : Window
    {
        Status_TableAdapter sta = new Status_TableAdapter();
        public ApplicationInfoWindowRemont()
        {
            InitializeComponent();
            AIWRDataGrid.ItemsSource = sta.GetData(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UsedParts_Window upw = new UsedParts_Window();
            upw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PartsWindowRemont pwr = new PartsWindowRemont();
            pwr.Show();
        }
    }
}
