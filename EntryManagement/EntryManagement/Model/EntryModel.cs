using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.Model
{
    public class EntryModel
    {
        public int Id { get; set; }

        public string MemberName { get; set; }

        public string CompanyName { get; set; }

        public DateTime EntryDate { get; set; }
    }
}
