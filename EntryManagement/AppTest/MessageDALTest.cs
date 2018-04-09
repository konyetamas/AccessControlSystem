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
            List<CompanyModel> companies = CompanyDAL.GetCompanies();
            MessagesFromBulidingModel model = new MessagesFromBulidingModel();
            model.Subject = "testSubject";
            model.Text = "testText";
            model.Companies = companies;
            MessageDAL.AddNewMessages(model);

           List<MessageToCompanyModel>messages= MessageDAL.GetMessagesFromBuilding();

            Assert.That(messages.Where(x=>x.Subject== "testSubject").Any(), Is.True);

        }

        [Test]
        public void AddNewMessagesCompanyIdTest()
        {
            List<CompanyModel> companies = CompanyDAL.GetCompanies();
            MessagesFromBulidingModel model = new MessagesFromBulidingModel();
            model.Subject = "testSubject";
            model.Text = "testText";
            model.Companies = companies;
            MessageDAL.AddNewMessages(model);

            List<MessageToCompanyModel> messages = MessageDAL.GetMessagesFromBuilding();

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
