using EntryManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.ViewModel
{
    public class OutboxMessageWindowViewModel
    {
        public ObservableCollection<MessageToCompanyModel> Messages { get; set; }

        public MessageToCompanyModel SelectedMessage { get; set; }
    }
}
