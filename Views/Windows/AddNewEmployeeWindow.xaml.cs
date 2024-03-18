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
using TsarevZadohinDemoCofe.Model;

namespace TsarevZadohinDemoCofe.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddNewEmployeeWindow.xaml
    /// </summary>
    public partial class AddNewEmployeeWindow : Window
    {
        public AddNewEmployeeWindow()
        {
            InitializeComponent();

            GenerateId();
            FillRoles();
            //AddEmployee();
        }

        private void AddNewEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee();
        }
        private void GenerateId()
        {
            //Получаем id из последних записи в БД
            int id = App.context.Employee.Max(e => e.Id);
            id++;
            IdTb.Text = id.ToString();
        }
        private void FillRoles()
        {
            RoleCmb.ItemsSource = App.context.Role.ToList();
            RoleCmb.DisplayMemberPath = "Name";
            RoleCmb.SelectedValuePath = "Id";
        }
        private void AddEmployee()
        {
            if(string.IsNullOrEmpty(NameTb.Text) || DateOfBirthDp.SelectedDate.Value == null ||  RoleCmb.SelectedValue == null || string.IsNullOrEmpty(LoginTb.Text) || string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                try
                {
                    Employee NewEmployee = new Employee()
                    {
                        Name = NameTb.Text,
                        DateOfBirth = DateOfBirthDp.SelectedDate.Value,
                        IsFired = false,
                        RoleId = Convert.ToInt32(RoleCmb.SelectedValue),
                        Login = LoginTb.Text,
                        Password = PasswordPb.Password
                    };
                    App.context.Employee.Add(NewEmployee);
                    App.context.SaveChanges();
                    MessageBox.Show("Пользователь добавлен");
                }
                catch ( Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
