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
    /// Interaction logic for AdminProfessor.xaml
    /// </summary>
    public partial class AdminProfessor : Page
    {
        public AdminProfessor()
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
        }
    }
}
