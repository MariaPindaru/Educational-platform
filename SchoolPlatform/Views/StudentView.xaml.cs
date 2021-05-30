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
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : Window
    {
        public StudentView()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new StudentGrades());
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new StudentAttendance());
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Close();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new StudentAverages());
        }
    }
}
