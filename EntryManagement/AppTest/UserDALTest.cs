using EntryManagement.DAL;
using EntryManagement.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest
{
    [TestFixture]
    public class UserDALTest
    {
        [Test]
        public void AddNewUserTest()
        {
            UserModel user = new UserModel() { Name = "testUser", Password = "xxx" };
            UserDAL.AddNewUser(user);
            List<UserModel> users = UserDAL.GetUsers();
            UserModel checkUser = users.Where(x => x.Name == "testUser").FirstOrDefault();

            Assert.That(checkUser!=null, Is.True);

        }
    }
}
