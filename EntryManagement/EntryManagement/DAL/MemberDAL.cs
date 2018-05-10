using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntryManagement.Model;
using DataBase;

namespace EntryManagement.DAL
{
    public class MemberDAL
    {
        public MemberModel CheckMemberByCardNumber(string CardNumber)
        {

            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                Member member = context.Members.Where(x => x.CardNumber == CardNumber).FirstOrDefault();
                if (member != null)
                    return MapToMemberModel(member, context);
                
                    
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return null;
        }


        public MemberModel GetMemberById(int Id)
        {

            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                Member member = context.Members.Where(x => x.Id == Id).FirstOrDefault();
                if (member != null)
                    return MapToMemberModel(member, context);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return null;
        }



        public List<MemberModel> GetMembers(string CardNumber)
        {

            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                List<Member> members = context.Members.ToList();
                List<MemberModel> memberModels = new List<MemberModel>();
                foreach (Member item in members)
                {
                    memberModels.Add(MapToMemberModel(item, context));
                }
                return memberModels;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return null;
        }


        public List<MemberModel> GetMembersOfCompany(int CompanyId)
        {

            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                List<Member> members = context.Members.Where(x=>x.CompanyId==CompanyId).ToList();
                List<MemberModel> memberModels = new List<MemberModel>();
                foreach (Member item in members)
                {
                    memberModels.Add(MapToMemberModel(item, context));
                }
                return memberModels;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return null;
        }


        public MemberModel MapToMemberModel(Member memberDataBase, AccessControlSystemEntities context)
        {
            MemberModel memberModel = new MemberModel();
            memberModel.Id = memberDataBase.Id;
            memberModel.CardNumber = memberDataBase.CardNumber;
            memberModel.Title = memberDataBase.Title;
            memberModel.FirstName = memberDataBase.FirstName;
            memberModel.LastName = memberDataBase.LastName;
            memberModel.CompanyName = (from x in context.Members
                                       where x.Id == memberModel.Id
                                       from y in context.Companies
                                       where y.Id == x.CompanyId
                                       select y.Name
                                      ).FirstOrDefault();

            return memberModel;
        }


    }
}
