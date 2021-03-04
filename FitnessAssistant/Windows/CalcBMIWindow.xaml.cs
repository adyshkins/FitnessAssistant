﻿using System;
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
    /// Логика взаимодействия для CalcBMIWindow.xaml
    /// </summary>
    public partial class CalcBMIWindow : Window
    {
        public CalcBMIWindow()
        {
            InitializeComponent();
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
            

            tbResult.Text = "Результат: ";
            tbResult.Text += Calculations.GetBMI(Int32.Parse(txtWeight.Text), Int32.Parse(txtHeight.Text)); 
        }
    }
}