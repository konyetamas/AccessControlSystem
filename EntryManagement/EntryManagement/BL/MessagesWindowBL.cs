using EntryManagement.DAL;
using EntryManagement.DB;
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
            List<MessageFromCompanyModel> messages = MessageDAL.GetMessagesFromCompanies();
            messagesFormCompanyToWindow = new ObservableCollection<MessageFromCompanyModel>();
            foreach (var item in messages)
            {
                messages.Add(item);
            }
        }

      
    }
}
