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
using TsarevZadohinDemoCofe;
using TsarevZadohinDemoCofe.Views.Pages;

namespace TsarevZadohinDemoCofe.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdministrationWindow.xaml
    /// </summary>
    public partial class AdministrationWindow : Window
    {
        public AdministrationWindow()
        {
            InitializeComponent();
        }

        private void EmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new EmplyeesPage());
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new OrdersPage());
        }

        private void ShiftBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new ShiftsPage());
        }
    }
}
