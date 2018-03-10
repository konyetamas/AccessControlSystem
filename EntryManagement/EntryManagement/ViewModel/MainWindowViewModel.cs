using EntryManagement.Model;
using Test1702.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.ViewModel
{
    public class MainWindowViewModel
    {
        public ObservableCollection<EntryModel> Entries { get; set; }

        public string UserFullName { get; set; }

        public Test1702.Model.MemberModel ActualMember { get; set; }

    }
}
