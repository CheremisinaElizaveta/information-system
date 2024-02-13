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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Window
    {

        user_TableAdapter utb = new user_TableAdapter();
        public RegPage()
        {
            InitializeComponent();

        } 
         private void RegisterButton_Click(object sender, RoutedEventArgs e)
            {

            // Проверка наличия заполненных полей
            if (string.IsNullOrEmpty(Login.Text) || string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(RepeatPassword.Text) || string.IsNullOrEmpty(Surname.Text) || string.IsNullOrEmpty(Name.Text) || string.IsNullOrEmpty(Surnamee.Text))
                {
                    MessageBox.Show("Заполните все поля");
                    return;
                }

            if (Password.Text != RepeatPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            // Добавление нового пользователя в базу данных
            utb.InsertQueryUser(Surname.Text, Name.Text, Surnamee.Text, Login.Text, Password.Text, 4);

            MessageBox.Show("Пользователь успешно зарегистрирован");

            // Очистка полей после регистрации
            Surname.Text = "";
            Name.Text = "";
            Surnamee.Text = "";
                Login.Text = "";
                Password.Text = "";
                RepeatPassword.Text = "";
                
            }
    }
}
