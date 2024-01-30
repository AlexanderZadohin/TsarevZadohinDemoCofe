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
        }

        private void ChangeStatusBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditEmployeeWindow addEditEmployeeWindow = new AddEditEmployeeWindow();
            addEditEmployeeWindow.ShowDialog();
        }
    }
}
