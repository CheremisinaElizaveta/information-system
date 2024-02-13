using Practika.TehSupportDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        user_TableAdapter utb = new user_TableAdapter();
        role_TableAdapter role = new role_TableAdapter();   
        public UsersWindow()
        {
            InitializeComponent();
            UserDG.ItemsSource = utb.GetData();
            Role.ItemsSource = role.GetData();
            Role.DisplayMemberPath = "role_id";
            Role.SelectedValuePath = "role_id";
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           object id = (UserDG.SelectedItem as DataRowView).Row[0];
            object idd = (UserDG.SelectedItem as DataRowView).Row[6];
            utb.UpdateQueryUser(Surname.Text,Name.Text,Surnamee.Text, Login.Text,Password.Text, Convert.ToInt32(idd), Convert.ToInt32(id));
            UserDG.ItemsSource = utb.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (UserDG.SelectedItem as DataRowView).Row[0];
            utb.DeleteQueryUser(Convert.ToInt32(id));
            UserDG.ItemsSource = utb.GetData();
        }

        private void UserDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView dataRowView = (DataRowView)UserDG.SelectedItem;
            if (dataRowView != null)
            {
                Surname.Text = dataRowView.Row[1].ToString();
                Name.Text = dataRowView.Row[2].ToString();
                Surnamee.Text = dataRowView.Row[3].ToString();
                Login.Text = dataRowView.Row[4].ToString();
                Password.Text = dataRowView.Row[5].ToString();
                Role.SelectedItem = dataRowView.Row[6];



            }
        }
    }
}
