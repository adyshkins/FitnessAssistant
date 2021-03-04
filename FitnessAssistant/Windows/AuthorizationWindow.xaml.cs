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
using FitnessAssistant.HelperClass;
using FitnessAssistant.Windows;
using static FitnessAssistant.EF.AppData;

namespace FitnessAssistant
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            txtLogin.Focus();
        }
       
        private void btnClose_Click(object sender, RoutedEventArgs e) 
        {
            Application.Current.Shutdown(); // выход из приложения
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (UserSearch.GetUser(txtLogin.Text, txtPassword.Password)) // поиск записи по логину и паролю
                {
                    UserWindow userWindow = new UserWindow();
                    this.Hide();
                    userWindow.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Пользователя с такими данными не существует");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnRegistr_Click(object sender, RoutedEventArgs e) // преход на страницу регистрации
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            this.Hide();
            registrationWindow.ShowDialog();
            this.Show();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnSignIn.Focus();
            }
        }
    }
}
