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
    public class MainWindowBL
    {
        public void InitEntriesList(ObservableCollection<EntryModel> EntriesModel)
        {
            EntriesModel.Clear();
            EntryDAL entryDAL = new EntryDAL();
            List<EntryModel> entries = entryDAL.GetEntries();
            foreach (var item in entries)
            {
                EntriesModel.Add(item);
            }
        }
    }
}
