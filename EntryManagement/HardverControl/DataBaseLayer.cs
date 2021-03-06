﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrHouse.Telnet;
using OKHOSTING.Core.Net4;
using OKHOSTING.Core.Net4.Net;
using DataBase;
using HardverControl.Model;

namespace HardverControl
{
    public class DataBaseLayer
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
            catch (Exception e)
            {

            }
            return null;
        }

        public bool MemberManagement(string cardnumber)
        {
            MemberModel actualMember = CheckMemberByCardNumber(cardnumber);
            if (actualMember != null)
            {
                AddNewEntryToDataBase(actualMember.Id);
            }
            else
            {
                DoorManagement(false);
                return false;
            }

            return true;

        }

        public static MemberModel MapToMemberModel(Member memberDataBase, AccessControlSystemEntities context)
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

        public void AddNewEntryToDataBase(int memberId)
        {
            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                Entry entry = new Entry();
                entry.MemberId = memberId;
                entry.Time = DateTime.Now;
                context.Entries.Add(entry);
                context.SaveChanges();
            }
            catch (Exception e)
            {

            }

        }

        public void DoorManagement(bool openDoor)
        {
            TelnetConnection tc = new TelnetConnection("192.168.4.1", 80);


            string message = openDoor == true ? "del" : "";
            if (tc.IsConnected)
            {
                Console.Write(tc.Read());
                tc.WriteLine(message);
                Console.Write(tc.Read());
            }
        }

    }
}
