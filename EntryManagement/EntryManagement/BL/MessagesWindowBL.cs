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
    public class InboxMessagesWindowBL
    {

        public void InitMessagesFromCompanyList(ObservableCollection<MessageFromCompanyModel> messagesFormCompanyToWindow)
        {
            List<MessageFromCompanyModel> messages = MessageDAL.GetMessagesFromCompanies();
            //messagesFormCompanyToWindow.Clear();
            //messagesFormCompanyToWindow = new ObservableCollection<MessageFromCompanyModel>();
            foreach (var item in messages)
            {
                messagesFormCompanyToWindow.Add(item);
            }
        }

      
    }
}
