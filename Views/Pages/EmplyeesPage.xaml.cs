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
    /// Логика взаимодействия для EmplyeesPage.xaml
    /// </summary>
    public partial class EmplyeesPage : Page
    {
        public EmplyeesPage()
        {
            InitializeComponent();

            EmployeeLv.ItemsSource = App.context.Employee.ToList();
        }

        private void ChangeStatusBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            AddNewEmployeeWindow addNewEmployeeWindow = new AddNewEmployeeWindow();
            addNewEmployeeWindow.Show();
        }

        private void FilrterByRoleCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EmployeeLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EmployeGrid.DataContext = EmployeeLv.SelectedItem as Employee;

            RoleCmb.ItemsSource = App.context.Role.ToList();
            RoleCmb.DisplayMemberPath = "Name";
            RoleCmb.SelectedValuePath = "id";
            RoleCmb.SelectedIndex = (EmployeeLv.SelectedItem as Employee).RoleId - 1;


            //EmployeeStatusCmb.ItemsSource = App.context.Role.ToList();
            //EmployeeStatusCmb.DisplayMemberPath = "Name";
            //EmployeeStatusCmb.SelectedValuePath = "id";
            //EmployeeStatusCmb.SelectedIndex = (EmployeeLv.SelectedItem as Employee).idEmployeeStatus - 1;
        }

        private void SaveChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            (EmployeeLv.SelectedItem as Employee).RoleId = Convert.ToInt32(RoleCmb.SelectedValue);
            App.context.SaveChanges();
            EmployeeLv.ItemsSource = App.context.Employee.ToList();
            MessageBox.Show("Данные пользователя изменены успешно!");
        }
    }
}
