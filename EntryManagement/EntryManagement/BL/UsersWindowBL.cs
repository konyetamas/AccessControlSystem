using EntryManagement.DAL;
using EntryManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.BL
{
    public class UsersWindowBL
    {
        public void InitUsersList(ObservableCollection<UserModel> userToWindow)
        {
            List<UserModel> users = new List<UserModel>();
             users = UserDAL.GetUsers();
            foreach (var item in users)
            {
                userToWindow.Add(item);
            }
        }

        public void AddNewUser(UserModel user)
        {
            UserDAL.AddNewUser(user);
        }

        public void DeleteUser(int Id)
        {
            UserDAL.DeleteUser(Id);
        }

    }
}
