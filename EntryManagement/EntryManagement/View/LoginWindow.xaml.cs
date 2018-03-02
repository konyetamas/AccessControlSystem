using EntryManagement.DAL;
using EntryManagement.Model;
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
using WindowsInput;

namespace EntryManagement
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()            
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginNameTextBox.Text != null && PasswordBox.Password != null)
            {
                UserModel CurrentUser = UserDAL.CheckUserAutenthication(LoginNameTextBox.Text, PasswordBox.Password);
                if (CurrentUser != null)
                {
                    
                    MainWindow mw = new MainWindow(CurrentUser);

                }
                else
                {
                    MessageBox.Show("Invalid password or nickname!");
                }
            }
            else
            {
                MessageBox.Show("Nickname and password cannot be null!");
            }
        }

      
    }
}
