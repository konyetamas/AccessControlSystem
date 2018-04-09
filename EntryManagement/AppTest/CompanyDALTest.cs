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
    public class CompanyDALTest
    {
        [Test]
        public void AddNewCompany()
        {
            CompanyModel model = new CompanyModel() {Name="testName", Address="testAddress", Phone="testPhone"};
            CompanyDAL.AddNewCompany(model);
          
            CompanyModel company = new CompanyModel();
            company = CompanyDAL.GetCompanies().Where(x => x.Name == "testName").FirstOrDefault();
            Assert.That(company != null, Is.True);

        }

        [Test]
        public void DeleteCompany()
        {
            int companyId = CompanyDAL.GetCompanies().Max(x=>x.Id);
            CompanyDAL.DeleteCompany(companyId);
            Assert.True(CompanyDAL.GetCompanyById(companyId) == null);
           
        }



    }
}
