using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using EntryManagement.Model;

namespace EntryManagement.ViewModel
{
    public class CompaniesWindowViewModel
    {
        public ObservableCollection<CompanyModel> Companies { get; set; }
    }
}
