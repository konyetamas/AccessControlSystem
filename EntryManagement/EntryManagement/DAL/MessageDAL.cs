﻿using System;
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
        public void AddNewMessages(MessagesFromBulidingModel messageModel)
        {
            AccessControlSystemEntities context = new AccessControlSystemEntities();
            MessageFromBuilding messageDB = new MessageFromBuilding();
            messageDB.Subject = messageModel.Subject;
            messageDB.Value = messageModel.Text;
            context.MessageFromBuildings.Add(messageDB);
            context.SaveChanges();
            foreach (var item in messageModel.Companies)
            {
                MessagesOfCompany newDBItem = new MessagesOfCompany();
                newDBItem.CompanyId = item.Id;
                newDBItem.MessageFromBuildingId = messageDB.Id;
                context.MessagesOfCompanies.Add(newDBItem);  
            }
            context.SaveChanges();
        }

        public List<MessageToCompanyModel> GetMessagesFromBuilding()
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
                throw new Exception(e.Message);
            }
            return null;
        }


        public List<MessageFromCompanyModel> GetMessagesFromCompanies()
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
                throw new Exception(e.Message);
            }
            return null;
        }

        private MessageFromCompanyModel MapToMemberMessageFromCompanyModel(MessageFromCompany messageFromCompanyDB, AccessControlSystemEntities context)
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


        private MessageToCompanyModel MapToMessageFromBulidingModel(MessagesOfCompany messageFromCompanyDB, AccessControlSystemEntities context)
        {
            MessageToCompanyModel messsageToCompany = new MessageToCompanyModel();
            messsageToCompany.Id = messageFromCompanyDB.Id;
            messsageToCompany.CompanyId = messageFromCompanyDB.CompanyId;
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
