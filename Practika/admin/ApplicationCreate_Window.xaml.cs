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
    /// Логика взаимодействия для ApplicationCreate_Window.xaml
    /// </summary>
    public partial class ApplicationCreate_Window : Window
    {

        application_TableAdapter application_TableAdapter = new application_TableAdapter();
        user_TableAdapter user_TableAdapter = new user_TableAdapter();
        Status_TableAdapter status_TableAdapter = new Status_TableAdapter();
        public ApplicationCreate_Window()
        {
            InitializeComponent();
            ApplicationIW.ItemsSource = application_TableAdapter.GetData();
            CBUser.ItemsSource = user_TableAdapter.GetData();
            CBStatus.ItemsSource = status_TableAdapter.GetData();

            CBUser.DisplayMemberPath = "user_id_";
            CBStatus.SelectedValuePath = "status_id";
            CBStatus.DisplayMemberPath = "status_id";
            CBUser.SelectedValuePath = "user_id_";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            PartsWindowAdmin pwa = new PartsWindowAdmin();
            pwa.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UsersWindow uw = new UsersWindow();
            uw.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (ApplicationIW.SelectedItem as DataRowView).Row[0];
            object idd = (ApplicationIW.SelectedItem as DataRowView).Row[1];
            object iddd = (ApplicationIW.SelectedItem as DataRowView).Row[3];
            application_TableAdapter.UpdateQuery(Convert.ToInt32(idd), Description.Text, Convert.ToInt32(iddd), DateTime.Today, Convert.ToInt32(id));
            ApplicationIW.ItemsSource = application_TableAdapter.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            application_TableAdapter.InsertQueryApplication(Convert.ToInt32(CBUser.SelectedValue), Description.Text, Convert.ToInt32(CBStatus.SelectedValue), DateTime.Today);
            ApplicationIW.ItemsSource = application_TableAdapter.GetData();
        }

        private void ApplicationIW_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView dataRowView = (DataRowView)ApplicationIW.SelectedItem;
            if (dataRowView != null)
            {
                Description.Text = dataRowView.Row[2].ToString();

                CBStatus.SelectedItem = dataRowView.Row[3];
                CBUser.SelectedItem = dataRowView.Row[1];



            }
        }
    }
}
