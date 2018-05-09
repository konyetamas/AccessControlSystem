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
            CompanyDAL companyDAL = new CompanyDAL();
            companyDAL.AddNewCompany(model);
          
            CompanyModel company = new CompanyModel();
            company = companyDAL.GetCompanies().Where(x => x.Name == "testName").FirstOrDefault();
            Assert.That(company != null, Is.True);

        }

        [Test]
        public void DeleteCompany()
        {
            CompanyDAL companyDAL = new CompanyDAL();
            int companyId = companyDAL.GetCompanies().Max(x=>x.Id);
            companyDAL.DeleteCompany(companyId);
            Assert.True(companyDAL.GetCompanyById(companyId) == null);
           
        }



    }
}
