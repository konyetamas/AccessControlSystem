using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.BL
{
    public class EntryWindowBL
    {
        const string URL= @"C:\Users\Tomi\Source\Repos\AccessControlSystem\EntryManagement\EntryManagement\Images\";

        public string GetImgUrl(int UserId)
        {
            return URL + UserId + ".jpg";
        }
    }
}
