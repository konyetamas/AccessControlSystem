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
     public class CompaniesWindowBL
    {
        public void InitCompaniesList(ObservableCollection<CompanyModel> CompaniesToWindow)
        {
            List<CompanyModel>companies= CompanyDAL.GetCompanies();
            CompaniesToWindow = new ObservableCollection<CompanyModel>();
            foreach (var item in companies)
            {
                CompaniesToWindow.Add(item);
            }
        }

        public void InitMembersOfCompanyList(ObservableCollection<MemberModel> MembersOfCompanyToWindow, int CompanyId)
        {
            List<MemberModel> members = MemberDAL.GetMembersOfCompany(CompanyId);
            MembersOfCompanyToWindow = new ObservableCollection<MemberModel>();
            foreach (var item in members)
            {
                MembersOfCompanyToWindow.Add(item);
            }
        }
    }
}
