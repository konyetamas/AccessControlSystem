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

        public static List<MessageToCompanyModel> GetMessagesFromBuilding()
        {

            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                List<MessagesOfCompany> messagesDB = context.MessagesOfCompanies.ToList();
                List<MessageToCompanyModel> messagesModel = new List<MessageToCompanyModel>();
                foreach (MessagesOfCompany item in messagesDB)
                {
                    messagesModel.Add(MapToMessageFromBulidingModel(item, context));
                }
                return messagesModel;
            }
            catch (Exception e)
            {

            }
            return null;
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
            messageFormCompany.Subject = messageFromCompanyDB.Subject;
            messageFormCompany.CompanyName = (from x in context.MessageFromCompanies
                                       where x.Id == messageFormCompany.Id
                                       from y in context.Companies
                                       where y.Id == x.CompanyId
                                       select y.Name
                                      ).FirstOrDefault();

            return messageFormCompany;
        }


        private static MessageToCompanyModel MapToMessageFromBulidingModel(MessagesOfCompany messageFromCompanyDB, AccessControlSystemEntities context)
        {
            MessageToCompanyModel messsageToCompany = new MessageToCompanyModel();
            messsageToCompany.Id = messageFromCompanyDB.Id;
            //messsageToCompany.CompanyName = messageFromCompanyDB.Value;
            messsageToCompany.CompanyName = (from x in context.Companies
                                              where x.Id == messageFromCompanyDB.CompanyId                                         
                                              select x.Name
                                      ).FirstOrDefault();
            messsageToCompany.Subject= (from x in context.MessageFromBuildings
                                        where x.Id == messageFromCompanyDB.MessageFromBuildingId
                                        select x.Subject
                                      ).FirstOrDefault();

            messsageToCompany.Text = (from x in context.MessageFromBuildings
                                         where x.Id == messageFromCompanyDB.MessageFromBuildingId
                                         select x.Value
                                    ).FirstOrDefault();

            return messsageToCompany;
        }



    }
}
