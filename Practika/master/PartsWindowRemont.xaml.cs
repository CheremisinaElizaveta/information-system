using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для PartsWindowRemont.xaml
    /// </summary>
    public partial class PartsWindowRemont : Window
    {

        
        partTableAdapter ppartTableAdapter = new partTableAdapter();
        public PartsWindowRemont()
        {
            InitializeComponent();
            PWRDataGrid.ItemsSource = ppartTableAdapter.GetData(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UsedParts_Window up_w = new UsedParts_Window();
            up_w.Show();    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ApplicationInfoWindowRemont aiwr = new ApplicationInfoWindowRemont();
            aiwr.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ppartTableAdapter.InsertQueryPart(Name.Text, Description.Text, Convert.ToInt32(Amount.Text));
            PWRDataGrid.ItemsSource = ppartTableAdapter.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            object id = (PWRDataGrid.SelectedItem as DataRowView).Row[0];
            ppartTableAdapter.DeleteQueryPart(Convert.ToInt32(id));
            PWRDataGrid.ItemsSource = ppartTableAdapter.GetData();
        }
    }
}
