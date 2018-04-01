using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntryManagement.Model;
using DataBase;

namespace EntryManagement.DAL
{
    public class UserDAL 
    {
        public static UserModel GetUserById(int Id)
        {
            try
            {
                AccessControlSystemEntities context = new AccessControlSystemEntities();
                User userDb = context.Users.Where(x => x.Id == Id).FirstOrDefault();
                if (userDb != null)
                    return MapToUserModel(userDb, context);
            }
            catch(Exception e)
            {

            }
            return null;
        }

        public static UserModel CheckUserAutenthication(string Name, string Password)
        {
            try
            {
                AccessControlSystemEntities context = new AccessControlSystemEntities();
                User userDb = context.Users.Where(x => x.Name == Name && x.Password==Password).FirstOrDefault();
                if (userDb != null)
                    return MapToUserModel(userDb, context);
            }
            catch (Exception e)
            {

            }
            return null;
        }

        private static UserModel MapToUserModel(User userDB, AccessControlSystemEntities context)
        {
            UserModel userModel = new UserModel();
            userModel.Id = userDB.Id;
            userModel.Name = userDB.Name;
            userModel.Role = userDB.Role;
            userModel.Password = userDB.Password;
         
            return userModel;
        }
    }
}
