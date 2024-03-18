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
using TsarevZadohinDemoCofe.Model;
using TsarevZadohinDemoCofe.Views.Windows;

namespace TsarevZadohinDemoCofe.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShiftsPage.xaml
    /// </summary>
    public partial class ShiftsPage : Page
    {
        public ShiftsPage()
        {
            InitializeComponent();

            ShiftsLv.ItemsSource = App.context.Shift.ToList();
        }

        private void ChangeStatusBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddShiftBtn_Click(object sender, RoutedEventArgs e)
        {
            AddShiftWindow addShiftWindow = new AddShiftWindow();
            addShiftWindow.ShowDialog();
        }

        private void ShiftsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Shift selectedShift = ShiftsLv.SelectedItem as Shift;
            ShiftGrid.DataContext = selectedShift;
            ShiftEmployeesLv.ItemsSource = App.context.Employee.Where(es => es.Id == selectedShift.Id).ToList();
        }

        private void AddNewShiftBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
