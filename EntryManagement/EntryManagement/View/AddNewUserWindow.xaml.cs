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
    /// Interaction logic for AddNewUserWindow.xaml
    /// </summary>
    public partial class AddNewUserWindow : Window
    {
        AddNewUserWindowViewModel VM;
        AddNewUserWindowBL BL;
        public AddNewUserWindow()
        {
            InitializeComponent();
            if(VM==null)
            {
                VM = new AddNewUserWindowViewModel();
                VM.Roles = new List<Model.RoleModel>();
                BL = new AddNewUserWindowBL();
                BL.InitRolesList(VM.Roles);
                this.DataContext = VM;
            }
           
        }

        private void AddNewUserbutton_Click(object sender, RoutedEventArgs e)
        {
            UserModel model = new UserModel();
            model.Name = UsertextBox.Text;
            model.Password = UsertextBox.Text;
            model.Role = VM.SelectedRole.Id;
            BL.AddNewUser(model);
            this.Close();
        }
    }
}
