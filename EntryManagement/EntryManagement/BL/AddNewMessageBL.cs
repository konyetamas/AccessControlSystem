using EntryManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.BL
{
  public class AddNewMessageBL
    {

        public void InitCompaniesList(ObservableCollection<CompanyModel> CompaniesToWindow)
        {
            List<CompanyModel> companies = DAL.CompanyDAL.GetCompanies();
            foreach (var item in companies)
            {
                CompaniesToWindow.Add(item);
            }
        }

        public void AddNewMessages(MessagesFromBulidingModel model)
        {
            DAL.MessageDAL.AddNewMessages(model);
        }
    }
}
