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
    public class MessageDALTest
    {
        [Test]
        public void AddNewMessagesSubjectTest()
        {
            CompanyDAL companyDAL = new CompanyDAL();
            List<CompanyModel> companies = companyDAL.GetCompanies();
            MessagesFromBulidingModel model = new MessagesFromBulidingModel();
            model.Subject = "testSubject";
            model.Text = "testText";
            model.Companies = companies;
            MessageDAL messageDAL = new MessageDAL();
            messageDAL.AddNewMessages(model);

           List<MessageToCompanyModel>messages= messageDAL.GetMessagesFromBuilding();

            Assert.That(messages.Where(x=>x.Subject== "testSubject").Any(), Is.True);

        }

        [Test]
        public void AddNewMessagesCompanyIdTest()
        {
            CompanyDAL companyDAL = new CompanyDAL();
            List<CompanyModel> companies = companyDAL.GetCompanies();
            MessagesFromBulidingModel model = new MessagesFromBulidingModel();
            model.Subject = "testSubject";
            model.Text = "testText";
            model.Companies = companies;
            MessageDAL messageDAL = new MessageDAL();
            messageDAL.AddNewMessages(model);

            List<MessageToCompanyModel> messages = messageDAL.GetMessagesFromBuilding();

            int counter= 0;
            foreach (var item in companies)
            {
               if( messages.Where(x => x.Subject == "testSubject" && x.CompanyId==item.Id).FirstOrDefault()!=null)
                {
                    counter++;
                }
            }

            Assert.That(counter == companies.Count, Is.True);

        }
    }
}
