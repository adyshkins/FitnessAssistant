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
using static FitnessAssistant.EF.AppData;

namespace FitnessAssistant.Windows
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();

            tbUserData.Text += userData.Name;

            tbName.Text = userData.Name;
            tbGender.Text = Context.Gender.
                Where(i=> i.IDGender == userData.IDGender).
                Select(i => i.GenderName).
                FirstOrDefault();
            tbAge.Text = userData.Age.ToString();
            tbHeight.Text = userData.Height.ToString();
            tbWeight.Text = userData.Weight.ToString();
            tbBMI.Text += HelperClass.Calculations.
                GetBMI(userData.Weight.Value, (userData.Height.Value));


        }
    }
}
