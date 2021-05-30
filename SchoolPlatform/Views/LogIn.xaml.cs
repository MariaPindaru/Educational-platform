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
using System.Windows.Shapes;

namespace SchoolPlatform.Views
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (username.Text == string.Empty || password.Password == string.Empty)
            {
                MessageBox.Show("Complete all fields!");
                return;
            }


            if (!(DataContext as LogInVM).ValidRegistration())
            {
                MessageBox.Show("Invalid username or password");
                return;
            }

            (DataContext as LogInVM).RememberUser();
            if ((DataContext as LogInVM).IsStudent())
            {
                StudentView studentView = new StudentView();
                studentView.Show();
                this.Close();
            }

            if ((DataContext as LogInVM).IsProfessor())
            {
                ProfessorView professorView = new ProfessorView();
                professorView.Show();
                this.Close();
            }

            if ((DataContext as LogInVM).IsAdmin())
            {
                AdminView adminView = new AdminView();
                adminView.Show();
                this.Close();
            }

        }

        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            {
                (DataContext as LogInVM).User.Password = ((PasswordBox)sender).Password;
            }
        }
    }
}
