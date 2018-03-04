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
            List<EntryModel> entries = EntryDAL.GetEntries();
            //EntriesModel = new ObservableCollection<EntryModel>();
            foreach (var item in entries)
            {
                EntriesModel.Add(item);
            }
        }
    }
}
