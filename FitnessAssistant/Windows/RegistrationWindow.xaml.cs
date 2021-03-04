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
using System.IO;
using FitnessAssistant.EF;
using Microsoft.Win32;

namespace FitnessAssistant.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private string pathPhoto;
        public RegistrationWindow()
        {
            InitializeComponent();
            cmbGender.ItemsSource = AppData.Context.Gender.ToList();
            cmbGender.DisplayMemberPath = "GenderName";
            cmbGender.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
               
        private void btnRegistr_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Поле Имя не может быть пустым");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Поле Логин не может быть пустым");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Поле Пароль не может быть пустым");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Поле Возраст не может быть пустым");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Поле Вес не может быть пустым");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Поле Рост не может быть пустым");
                return;
            }
            int val;

            if (!Int32.TryParse(txtAge.Text, out val))
            {
                MessageBox.Show("Введены недопустимые значения в поле Возраст");
                return;
            }

            if (!Int32.TryParse(txtWeight.Text, out val))
            {
                MessageBox.Show("Введены недопустимые значения в поле Вес");
                return;
            }

            if (!Int32.TryParse(txtHeight.Text, out val))
            {
                MessageBox.Show("Введены недопустимые значения в поле Рост");
                return;
            }

           

            Users addUser = new Users();
            addUser.Name = txtName.Text;
            addUser.Height = Int32.Parse(txtHeight.Text);
            addUser.Weight = Int32.Parse(txtWeight.Text);
            addUser.Login = txtLogin.Text;
            addUser.Password = txtPassword.Text;
            addUser.Age = Int32.Parse(txtAge.Text);
            addUser.IDGender = cmbGender.SelectedIndex + 1;

            if (pathPhoto != null)
            {
                addUser.Photo = File.ReadAllBytes(pathPhoto);
            }

            AppData.Context.Users.Add(addUser);
            AppData.Context.SaveChanges();
            MessageBox.Show($"Пользователь {txtName.Text} добавлен");
            Close();
        }

        private void btnChoosePhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            pathPhoto = openFileDialog.FileName;
            imgPhotoUser.Source = new BitmapImage(new Uri(pathPhoto));
        }
    }
}
