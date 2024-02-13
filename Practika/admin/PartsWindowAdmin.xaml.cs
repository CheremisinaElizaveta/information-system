using Practika.TehSupportDataSetTableAdapters;
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

namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для PartsWindowAdmin.xaml
    /// </summary>
    public partial class PartsWindowAdmin : Window
    {
        partTableAdapter part = new partTableAdapter();
        public PartsWindowAdmin()
        {
            InitializeComponent();
            PartsDataGrid.ItemsSource = part.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationCreate_Window apcw = new ApplicationCreate_Window();
            apcw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UsersWindow uw = new UsersWindow();
            uw.Show();  
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            part.InsertQueryPart(Name.Text, Description.Text, Convert.ToInt32(Amount.Text));
            PartsDataGrid.ItemsSource = part.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            object id = (PartsDataGrid.SelectedItem as DataRowView).Row[0];
            part.DeleteQueryPart(Convert.ToInt32(id));
            PartsDataGrid.ItemsSource = part.GetData();
        }

       
    }
}
