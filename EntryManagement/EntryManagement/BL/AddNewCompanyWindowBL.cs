using EntryManagement.DAL;
using EntryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.BL
{
    public class AddNewCompanyWindowBL
    {
        public void AddNewCompany(CompanyModel model)
        {
            CompanyDAL.AddNewCompany(model);
        }
    }
}
