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
    /// Логика взаимодействия для CookWindow.xaml
    /// </summary>
    public partial class CookWindow : Window
    {
        public CookWindow()
        {
            InitializeComponent();
            EmployeeLv.ItemsSource = App.context.OrderPosition.ToList();

        }

        private void CookCheck_Checked(object sender, RoutedEventArgs e)
        {

            App.context.SaveChanges();
        }

        private void CookCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            App.context.SaveChanges();
        }

        private void SaveChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            App.context.SaveChanges();

            MessageBoxHelper.Information("Статус заказа успешно сохранен");
        }

        private void EmployeeLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EmployeeLv.DataContext = EmployeeLv.SelectedItem as OrderPosition;
        }
    }
}
