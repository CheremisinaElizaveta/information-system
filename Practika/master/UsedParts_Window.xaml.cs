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
using Practika.TehSupportDataSetTableAdapters;
namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для UsedParts_Window.xaml
    /// </summary>
    public partial class UsedParts_Window : Window
    {
        used_partTableAdapter used_PartTable = new used_partTableAdapter();
        partTableAdapter partTableAdapter = new partTableAdapter();
        application_TableAdapter applicationTableAdapter = new application_TableAdapter();

        public UsedParts_Window()
        {
            InitializeComponent();
            UPDataGrid.ItemsSource = used_PartTable.GetData();

            Part.ItemsSource = partTableAdapter.GetData();
            Application.ItemsSource = applicationTableAdapter.GetData();

            Part.DisplayMemberPath = "part_id";

            Application.SelectedValuePath = "application_id";
            Application.DisplayMemberPath = "application_id";

            Part.SelectedValuePath = "part_id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PartsWindowRemont pwr = new PartsWindowRemont();
            pwr.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ApplicationInfoWindowRemont aiwr = new ApplicationInfoWindowRemont();
            aiwr.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            used_PartTable.InsertQueryUsedPart(Convert.ToInt32(Part.SelectedValue), Convert.ToInt32(Application.SelectedValue), Convert.ToInt32(Amount.Text));
            UPDataGrid.ItemsSource = used_PartTable.GetData();
        }
    }
}
