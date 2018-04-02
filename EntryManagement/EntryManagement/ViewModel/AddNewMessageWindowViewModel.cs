using EntryManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.ViewModel
{
   public class AddNewMessageWindowViewModel
    {

        public ObservableCollection<CompanyModel> Companies { get; set; }

        public ObservableCollection<CompanyModel> AddedCompanies { get; set; }

        public CompanyModel SelectedCompany { get; set; }

    }
}
