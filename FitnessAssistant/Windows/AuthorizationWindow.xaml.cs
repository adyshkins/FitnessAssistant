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
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userLog = Context.Users.ToList().
               Where(i => i.Login == txtLogin.Text && i.Password == txtPassword.Password).
               FirstOrDefault();

                if (userLog != null)
                {
                    userData = userLog;

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

        private void btnRegistr_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            this.Hide();
            registrationWindow.ShowDialog();
            this.Show();
        }
    }
}
