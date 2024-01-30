﻿using System;
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
using TsarevZadohinDemoCofe.Views.Pages;

namespace TsarevZadohinDemoCofe.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для WaiterWindow.xaml
    /// </summary>
    public partial class WaiterWindow : Window
    {
        public WaiterWindow()
        {
            InitializeComponent();
        }

        private void ViewOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new OrdersPage());
        }

        private void CreateOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            //MainFrm.Navigate(new)
        }
    }
}
