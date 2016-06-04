using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TaskForPlarium
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void OnStartup(Object sender, StartupEventArgs e)
        {
            Views.MainWindow  view = new Views.MainWindow();
            view.DataContext = new ViewModels.CalculatorViewModel();
            view.Show();
        }
    }
}
