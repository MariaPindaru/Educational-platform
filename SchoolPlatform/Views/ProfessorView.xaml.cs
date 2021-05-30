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
    /// Interaction logic for ProfessorView.xaml
    /// </summary>
    public partial class ProfessorView : Window
    {
        public ProfessorView()
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
            frame.Navigate(new ProfessorGrades());
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ProfessorAttendance());
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new HeadMasterAttendanceAll());
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ProfessorAverageGrades());
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new HeadMasterAverages());
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new HeadMasterHierarchy());
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new HeadMasterFirst4());
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new HeadMasterFails());
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new HeadMasterExpulsion());
        }
    }
}
