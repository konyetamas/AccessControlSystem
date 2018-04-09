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
                List<CompanyModel> companiesModel = new List<CompanyModel>();
                foreach (Company item in companies)
                {
                    companiesModel.Add(MapToCompanyModel(item, context));
                }
                return companiesModel;
            }
            catch (Exception e)
            {

            }
            return null;
        }

        public static CompanyModel GetCompanyById(int Id)
        {
            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                Company companyDB = context.Companies.Where(x => x.Id == Id).FirstOrDefault();
                if (companyDB != null)
                    return MapToCompanyModel(companyDB, context);
            }
            catch (Exception e)
            {

            }
            return null;
        }

        public static void AddNewCompany(CompanyModel company)
        {
            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                Company companyDB = new Company();
                companyDB.Name = company.Name;
                companyDB.Address = company.Address;
                companyDB.Phone = company.Phone;
                context.Companies.Add(companyDB);
                context.SaveChanges();
            }
            catch (Exception e)
            {

            }

         }

        public static void DeleteCompany(int companyId)
        {
            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                Company companyDB = context.Companies.Where(x => x.Id == companyId).FirstOrDefault();
                context.Companies.Remove(companyDB);
                context.SaveChanges();
            }
            catch (Exception e)
            {

            }

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
