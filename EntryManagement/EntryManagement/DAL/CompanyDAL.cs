using DataBase;
using EntryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.DAL
{
    public class CompanyDAL
    {
        public static List<CompanyModel> GetCompanies()
        {

            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                List<Company> companies = context.Companies.ToList();
                List<CompanyModel> memberModels = new List<CompanyModel>();
                foreach (Company item in companies)
                {
                    memberModels.Add(MapToCompanyModel(item, context));
                }
                return memberModels;
            }
            catch (Exception e)
            {

            }
            return null;
        }


        public static CompanyModel MapToCompanyModel(Company companyDataBase, AccessControlSystemEntities context)
        {
            CompanyModel companyModel = new CompanyModel();
            companyModel.Id = companyDataBase.Id;
            companyModel.Name = companyDataBase.Name;
            companyModel.Address = companyDataBase.Address;
            companyModel.Phone = companyDataBase.Phone;

            return companyModel;
        }
    }
}
