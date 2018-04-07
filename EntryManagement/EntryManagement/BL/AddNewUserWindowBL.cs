using EntryManagement.DAL;
using EntryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.BL
{
    public class AddNewUserWindowBL
    {
        public void AddNewUser(UserModel model)
        {
            UserDAL.AddNewUser(model);
        }

      

        public void InitRolesList(List<RoleModel> Roles)
        {
            Roles.Add(new RoleModel() { Id = 0, Value = "system adniminstrator" });
            Roles.Add(new RoleModel() { Id = 1, Value = "portás" });
            Roles.Add(new RoleModel() { Id = 2, Value = "manager" });
        }
    }
}
