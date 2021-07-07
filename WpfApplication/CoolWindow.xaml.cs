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

namespace WpfApplication
{
    /// <summary>
    /// Logique d'interaction pour CoolWindow.xaml
    /// </summary>
    public partial class CoolWindow : Window
    {
        public CoolWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            string ress = Application.Current.FindResource("WindowBackgroundBrush").ToString();
            MessageBox.Show($"Ressource : {ress}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            BindingWindow wnd = new BindingWindow();
            wnd.Show();
        }
    }
}
