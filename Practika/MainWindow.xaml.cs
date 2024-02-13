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
using Practika.TehSupportDataSetTableAdapters;

namespace Practika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        user_TableAdapter user_TableAdapter = new user_TableAdapter();
        public MainWindow()
        {
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegPage regpage = new RegPage();
            regpage.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var allLogins = user_TableAdapter.GetData().Rows;
            for (int i = 0; i < allLogins.Count; i++)
            {
                if (allLogins[i][4].ToString() == Login.Text && allLogins[i][5].ToString() == Password.Text)
                {
                    int roleId = (int)allLogins[i][6];

                    switch (roleId)
                    {
                        case 1:
                            PartsWindowAdmin PartsAdmin = new PartsWindowAdmin();
                            PartsAdmin.Show();
                            return;
                        case 2:
                            ApplicationInfoWindow applicationInfoWindow = new ApplicationInfoWindow();
                            applicationInfoWindow.Show();
                            return;
                        case 3:
                            ApplicationInfoWindowRemont applicationInfoWindowRemont = new ApplicationInfoWindowRemont();
                            applicationInfoWindowRemont.Show();
                            return;
                        case 4: 
                            ApplicationInfo_Window applicationInfo_Window = new ApplicationInfo_Window();  
                            applicationInfo_Window.Show();
                            return;
                        

                    }
                }
            }
            MessageBox.Show("такого пользователя нет");

        }
    }   
    
}
