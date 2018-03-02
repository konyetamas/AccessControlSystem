using EntryManagement.DB;
using EntryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.DAL
{
    public class EntryDAL
    {
        public static List<EntryModel> GetEntries()
        {

            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                List<Entry> entries = context.Entries.ToList();
                List<EntryModel> entryModels = new List<EntryModel>();
                foreach (Entry item in entries)
                {
                    entryModels.Add(MapToEntryModel(item, context));
                }
                return entryModels;
            }
            catch (Exception e)
            {

            }
            return null;
        }


        public static EntryModel MapToEntryModel(Entry entryDataBase, AccessControlSystemEntities context)
        {
            EntryModel entryModel = new EntryModel();
            entryModel.Id = entryDataBase.Id;
            entryModel.MemberName = (from x in context.Members
                                     where x.Id == entryDataBase.MemberId
                                     select x.FirstName + x.LastName
                                      ).FirstOrDefault();
            entryModel.CompanyName = (from x in context.Members
                                      where x.Id == entryDataBase.MemberId
                                      from y in context.Companies
                                      where y.Id== x.CompanyId
                                      select y.Name
                                      ).FirstOrDefault();


            return entryModel;
        }
    }
}
