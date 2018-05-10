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
        public UserModel GetUserById(int Id)
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
                throw new Exception(e.Message);
            }
            return null;
        }

        public List<UserModel> GetUsers()
        {
            List<UserModel> usersModel = new List<UserModel>();
            try
            {
                AccessControlSystemEntities context = new AccessControlSystemEntities();
                
                List<User> usersDb = context.Users.ToList();
                foreach (var item in usersDb)
                {
                    usersModel.Add(MapToUserModel(item, context));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return usersModel;
        }

        public void AddNewUser(UserModel model)
        {
            try
            {
                AccessControlSystemEntities context = new AccessControlSystemEntities();
                User userDB = new User();
                userDB.Name = model.Name;
                userDB.Password = model.Password;
                userDB.Role = model.Role;
                context.Users.Add(userDB);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteUser(int UserId)
        {
            try
            {
                AccessControlSystemEntities context = new AccessControlSystemEntities();
                User userDB = context.Users.Where(x => x.Id == UserId).FirstOrDefault();
                context.Users.Remove(userDB);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public UserModel CheckUserAutenthication(string Name, string Password)
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
                throw new Exception(e.Message);
            }
            return null;
        }

        private UserModel MapToUserModel(User userDB, AccessControlSystemEntities context)
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
