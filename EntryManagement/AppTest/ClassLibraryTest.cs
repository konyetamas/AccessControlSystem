using EntryManagement.DAL;
using EntryManagement.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1702;

namespace AppTest
{
    [TestFixture]
    public class ClassLibraryTest
    {
        [Test]
        public void CheckMemberByCardNumberTest()
        {
            int companyId = CompanyDAL.GetCompanies().Select(x => x.Id).Min();
            List<MemberModel> members = MemberDAL.GetMembersOfCompany(companyId);
            string cardnumber = members.First().CardNumber;
            DataBaseLayer db = new DataBaseLayer();
            Test1702.Model.MemberModel testmodel =db.CheckMemberByCardNumber(cardnumber);
            Assert.That(testmodel!=null, Is.True);
        }
    }
}
