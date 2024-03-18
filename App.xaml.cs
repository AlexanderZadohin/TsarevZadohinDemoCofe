using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TsarevZadohinDemoCofe.Model;

namespace TsarevZadohinDemoCofe
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static CafeZadohinDemoEntities context = new CafeZadohinDemoEntities();
    }
}
