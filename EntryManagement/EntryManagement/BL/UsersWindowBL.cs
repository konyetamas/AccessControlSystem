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
            UserDAL userDAL = new UserDAL();
             users = userDAL.GetUsers();
            foreach (var item in users)
            {
                userToWindow.Add(item);
            }
        }

        public void AddNewUser(UserModel user)
        {
            UserDAL userDAL = new UserDAL();
            userDAL.AddNewUser(user);
        }

        public void DeleteUser(int Id)
        {
            UserDAL userDAL = new UserDAL();
            userDAL.DeleteUser(Id);
        }

    }
}
