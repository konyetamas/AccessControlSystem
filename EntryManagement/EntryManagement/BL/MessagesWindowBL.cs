using EntryManagement.DAL;
using EntryManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.BL
{
    public class MessagesWindowBL
    {

        public void InitMessagesFromCompanyList(ObservableCollection<MessageFromCompanyModel> messagesFormCompanyToWindow)
        {
            MessageDAL messageDAL = new MessageDAL();
            List<MessageFromCompanyModel> messages = messageDAL.GetMessagesFromCompanies();

            foreach (var item in messages)
            {
                messagesFormCompanyToWindow.Add(item);
            }
        }

        public void InitMessagesFromBuliding(ObservableCollection<MessageToCompanyModel> messagesToCompanyToWindow)
        {
            MessageDAL messageDAL = new MessageDAL();
            List<MessageToCompanyModel> messages = messageDAL.GetMessagesFromBuilding();
            foreach (var item in messages)
            {
                messagesToCompanyToWindow.Add(item);
            }
        }


    }
}
