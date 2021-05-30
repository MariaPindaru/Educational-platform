using SchoolPlatform.Models;
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
    /// Interaction logic for AdminSubjects.xaml
    /// </summary>
    public partial class AdminSubjects : Page
    {
        public AdminSubjects()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datagrid1.SelectedItem = null;
            prof.Text = string.Empty;
            subject.Text = string.Empty;
        }
    }
}