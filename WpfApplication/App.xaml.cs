using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public void Application_Startup(Object sender, StartupEventArgs e)
        {

            //CoolWindow wnd = new CoolWindow();
            BindingWindow wnd = new BindingWindow();
            wnd.Title = "Hello MC!";
            //wnd.ResizeMode = ResizeMode.NoResize;
            //wnd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //wnd.Width = wnd.Height = 400;

            wnd.Closing += Wnd_Closing;
            wnd.Show();
        }

        private void Wnd_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MessageBox.Show("Really?! bye :(");
        }
    }
}
