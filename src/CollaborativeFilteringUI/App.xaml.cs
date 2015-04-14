using StructureMap;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace CollaborativeFilteringUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Bootstrapper.Initialize();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            IMainWindowViewModel window = ObjectFactory.GetInstance<IMainWindowViewModel>();
            MainWindow = (MainWindow)window.Window;
            MainWindow.ShowDialog();
        }
    }
}
