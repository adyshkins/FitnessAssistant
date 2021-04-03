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
    /// Логика взаимодействия для MyWorkoutsWindow.xaml
    /// </summary>
    public partial class MyWorkoutsWindow : Window
    {
        public MyWorkoutsWindow()
        {
            InitializeComponent();

            lvWorkouts.ItemsSource = Context.UserWorkout.Where(i => i.IdUser == userData.ID).ToList();
        }

        private void btnAddWorkout_Click(object sender, RoutedEventArgs e)
        {
            AddWorkoutWindow addWorkoutWindow = new AddWorkoutWindow();
            this.Opacity = 0.6;
            addWorkoutWindow.ShowDialog();
            lvWorkouts.ItemsSource = Context.UserWorkout.Where(i => i.IdUser == userData.ID).ToList();

            this.Opacity = 1;
        }
    }
}
