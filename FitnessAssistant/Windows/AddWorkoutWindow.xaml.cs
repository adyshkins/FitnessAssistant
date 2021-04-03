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
    /// Логика взаимодействия для AddWorkoutWindow.xaml
    /// </summary>
    public partial class AddWorkoutWindow : Window
    {
        public AddWorkoutWindow()
        {
            InitializeComponent();
            cmbTypeWorkout.ItemsSource = Context.TypeWorkout.ToList();
            cmbTypeWorkout.DisplayMemberPath = "NameTypeWorkout";
            cmbTypeWorkout.SelectedIndex = 0;

            dpDateWorkout.SelectedDate = DateTime.Now;
        }

        private void txtDurationWorkout_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            uint val;
            if (!uint.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void btnAddWorkout_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Добавить новую тренировку?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                EF.UserWorkout userWorkout = new EF.UserWorkout();

                userWorkout.IdUser = EF.AppData.userData.ID;
                userWorkout.DateWorkout = dpDateWorkout.DisplayDate;
                userWorkout.DurationWorkout = Int32.Parse(txtDurationWorkout.Text);
                userWorkout.IdTypeWorkout = cmbTypeWorkout.SelectedIndex + 1;


                Context.UserWorkout.Add(userWorkout);

                Context.SaveChanges();

                MessageBox.Show("Новая тренировка добавлена");
                this.Close();
            }
            
        }
    }
}
