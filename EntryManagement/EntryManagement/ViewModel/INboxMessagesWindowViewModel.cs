using EntryManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.ViewModel
{
    public class InboxMessagesWindowViewModel
    {
        public ObservableCollection<MessageFromCompanyModel> Messages { get; set; }

        public MessageFromCompanyModel SelectedMessage { get; set; }

    }
}
