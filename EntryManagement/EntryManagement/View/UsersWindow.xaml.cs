using EntryManagement.BL;
using EntryManagement.Model;
using EntryManagement.ViewModel;
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

namespace EntryManagement.View
{
    /// <summary>
    /// Interaction logic for UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        UsersWindowViewModel VM;
        UsersWindowBL BL;
        public UsersWindow()
        {
            InitializeComponent();
            if (VM == null)
            {
                VM = new UsersWindowViewModel();
                VM.Users = new System.Collections.ObjectModel.ObservableCollection<Model.UserModel>();
                this.DataContext = VM;
            }
            BL = new UsersWindowBL();
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BL.DeleteUser(VM.SelectedUser.Id);
                VM.Users.Clear();
                BL.InitUsersList(VM.Users);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNewUserButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddNewUserWindow anuw = new AddNewUserWindow();
                anuw.ShowDialog();
                VM.Users.Clear();
                BL.InitUsersList(VM.Users);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UsersListView_Loaded(object sender, RoutedEventArgs e)
        {
            BL.InitUsersList(VM.Users);
        }
    }
}
