using SchoolPlatform.ViewModels;
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

namespace SchoolPlatform.Views
{
    /// <summary>
    /// Interaction logic for AdminStudents.xaml
    /// </summary>
    public partial class AdminStudents : Page
    {
        public AdminStudents()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datagrid.SelectedItem = null;
            firstname.Text = string.Empty;
            lastname.Text = string.Empty;
            username.Text = string.Empty;
            password.Text = string.Empty;
            spec.Text = string.Empty;
            combo.SelectedIndex = -1;
        }
    }
}
