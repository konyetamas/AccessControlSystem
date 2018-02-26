using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class MemberDAL
    {
        public static Member GetMemberByCardNumber(string CardNumber)
        {
            AccessControlSystemEntities context = new AccessControlSystemEntities();
            Member member = context.Members.Where(x => x.CardNumber == CardNumber).FirstOrDefault();
            return member;
        }

        //public List<>
    }
}
