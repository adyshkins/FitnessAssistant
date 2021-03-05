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
using FitnessAssistant.HelperClass;

namespace FitnessAssistant.Windows
{
    /// <summary>
    /// Логика взаимодействия для CalcBMRWindow.xaml
    /// </summary>
    public partial class CalcBMRWindow : Window
    {
        int gender = 1;
        public CalcBMRWindow()
        {
            InitializeComponent();


            btnGemderMale.BorderBrush = Brushes.Black;
            btnGemderMale.BorderThickness = new Thickness(2);

            btnGemderFeMale.BorderBrush = Brushes.Gray;
            btnGemderFeMale.BorderThickness = new Thickness(1);
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Укажите Ваш вес");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Укажите Ваш рост");
                return;
            }

            int val;
            if (!Int32.TryParse(txtWeight.Text, out val))
            {
                MessageBox.Show("Неверный формат данных  в поле Вес");
                return;
            }
            if (!Int32.TryParse(txtHeight.Text, out val))
            {
                MessageBox.Show("Неверный формат данных в поле Рост");
                return;
            }
            double BMR = Calculations.GetBMR(gender, Int32.Parse(txtHeight.Text), Int32.Parse(txtWeight.Text), Int32.Parse(txtAge.Text));
            tbBMR.Text = "Ваш BMR: \n";
            tbBMR.Text += BMR;

            tbActivityLevel1.Text = "Сидячий образ: " + (BMR * 1.2).ToString();
            tbActivityLevel2.Text = "Маленькая активность: " + (BMR * 1.375).ToString();
            tbActivityLevel3.Text = "Средняя активность: " + (BMR * 1.55).ToString();
            tbActivityLevel4.Text = "Сильная активность: " + (BMR * 1.725).ToString();
            tbActivityLevel5.Text = "Максимальная активность: " + (BMR * 1.9).ToString();
        }

        private void btnGemderMale_Click(object sender, RoutedEventArgs e)
        {
            gender = 1;
            btnGemderMale.BorderBrush = Brushes.Black;
            btnGemderMale.BorderThickness = new Thickness(2);

            btnGemderFeMale.BorderBrush = Brushes.Gray;
            btnGemderFeMale.BorderThickness = new Thickness(1);
        }

        private void btnGemderFeMale_Click(object sender, RoutedEventArgs e)
        {
            gender = 2;
            btnGemderFeMale.BorderBrush = Brushes.Black;
            btnGemderFeMale.BorderThickness = new Thickness(2);

            btnGemderMale.BorderBrush = Brushes.Gray;
            btnGemderMale.BorderThickness = new Thickness(1);
        }
    }
}
