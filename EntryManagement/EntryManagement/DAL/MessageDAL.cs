using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntryManagement.Model;
using DataBase;

namespace EntryManagement.DAL
{
    public class MessageDAL
    {
        public static void AddNewMessage()
        {
            AccessControlSystemEntities context = new AccessControlSystemEntities();
            
        }


        public static List<MessageFromCompanyModel> GetMessagesFromCompanies()
        {

            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                List<MessageFromCompany> messagesDB = context.MessageFromCompanies.ToList();
                List<MessageFromCompanyModel> messagesModel = new List<MessageFromCompanyModel>();
                foreach (MessageFromCompany item in messagesDB)
                {
                    messagesModel.Add(MapToMemberMessageFromCompanyModel(item, context));
                }
                return messagesModel;
            }
            catch (Exception e)
            {

            }
            return null;
        }

        private static MessageFromCompanyModel MapToMemberMessageFromCompanyModel(MessageFromCompany messageFromCompanyDB, AccessControlSystemEntities context)
        {
            MessageFromCompanyModel messageFormCompany = new MessageFromCompanyModel();
            messageFormCompany.Id = messageFromCompanyDB.Id;
            messageFormCompany.Text = messageFromCompanyDB.Value;
            messageFormCompany.CompanyName = (from x in context.MessageFromCompanies
                                       where x.Id == messageFormCompany.Id
                                       from y in context.Companies
                                       where y.Id == x.CompanyId
                                       select y.Name
                                      ).FirstOrDefault();

            return messageFormCompany;
        }


    }
}
