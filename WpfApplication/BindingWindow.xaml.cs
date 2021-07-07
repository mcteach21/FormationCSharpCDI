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
    /// Logique d'interaction pour BindingWindow.xaml
    /// </summary>
    public partial class BindingWindow : Window
    {
        public BindingWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnUpdate_Binding(object sender, RoutedEventArgs e)
        {
            txtTitle.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Binding2Window().Show();
            Hide();
        }
    }
}
