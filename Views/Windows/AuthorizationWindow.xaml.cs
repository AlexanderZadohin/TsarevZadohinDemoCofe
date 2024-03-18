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
using TsarevZadohinDemoCofe.AppData;
using TsarevZadohinDemoCofe.Model;

namespace TsarevZadohinDemoCofe.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();

        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            // Взять запись из таблицы, которая подходит условию
            Employee employee = App.context.Employee.FirstOrDefault(emp => emp.Login == LoginTb.Text && emp.Password == PasswordPb.Password);

            //Проверка на "Пустое значение" у записи
            if (employee != null)
            {
                //Открыть окно в зависимости от роли
                switch(employee.RoleId)
                {
                    case 1:
                        AdministrationWindow administrationWindow = new AdministrationWindow();
                        administrationWindow.Show();
                        break;

                    case 2:
                        CookWindow cookWindow = new CookWindow();
                        cookWindow.Show();
                        break;
                    case 3:
                        WaiterWindow waiterWindow = new WaiterWindow();
                        waiterWindow.Show();
                        break;
                }
                Close();
            }
            else
            {
                MessageBoxHelper.Error("Неправильно введен логин и или пароль");
                //
            }
        }
    }
}
