using Practika.TehSupportDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
using static System.Net.Mime.MediaTypeNames;

namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для ApplicationCreateWindow.xaml
    /// </summary>
    public partial class ApplicationCreateWindow : Window
    {
        application_TableAdapter application_TableAdapter = new application_TableAdapter();
        user_TableAdapter user_TableAdapter = new user_TableAdapter();
        Status_TableAdapter status_TableAdapter = new Status_TableAdapter();
        public ApplicationCreateWindow()
        {
            InitializeComponent();
            
            CBUser.ItemsSource = user_TableAdapter.GetData();
            CBStatus.ItemsSource = status_TableAdapter.GetData();

            CBUser.DisplayMemberPath = "user_id_";

            CBStatus.SelectedValuePath = "status_id";
            CBStatus.DisplayMemberPath = "status_id";

            CBUser.SelectedValuePath = "user_id_";
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PartsWindow pw = new PartsWindow();
            pw.Show();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ApplicationInfoWindow aiw = new ApplicationInfoWindow();
            aiw.Show(); 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            application_TableAdapter.InsertQueryApplication(Convert.ToInt32(CBUser.SelectedValue), Description.Text, Convert.ToInt32(CBStatus.SelectedValue), DateTime.Today);
            
        }
    }
}
