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

namespace SchoolPlatform.Views
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new AdminStudents());
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new AdminProfessor());
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new AdminSubjects());
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new AdminSpecializations());
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new AdminHeadMasters());
        }
    }
}
