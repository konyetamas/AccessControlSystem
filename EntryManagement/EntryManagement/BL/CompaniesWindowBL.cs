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
            CompanyDAL companyDAL = new CompanyDAL();
            List<CompanyModel> companies = companyDAL.GetCompanies();
            // CompaniesToWindow = new ObservableCollection<CompanyModel>();
            foreach (var item in companies)
            {
                CompaniesToWindow.Add(item);
            }
        }

        public void InitMembersOfCompanyList(ObservableCollection<MemberModel> MembersOfCompanyToWindow, int CompanyId)
        {
            MemberDAL memberDAL = new MemberDAL();
            List<MemberModel> members = memberDAL.GetMembersOfCompany(CompanyId);
            MembersOfCompanyToWindow.Clear();
            // MembersOfCompanyToWindow = new ObservableCollection<MemberModel>();
            foreach (var item in members)
            {
                MembersOfCompanyToWindow.Add(item);
            }
        }

        public void DeleteSelectedCompany(int CompanyId)
        {
            CompanyDAL companyDAL = new CompanyDAL();
            companyDAL.DeleteCompany(CompanyId);
        }
    }
}
