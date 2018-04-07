﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagement.ViewModel
{
    public class AddNewUserWindowViewModel
    {
        public List<RoleModel> Roles { get; set; }

    }

    public class RoleModel
    {
        public int Id { get; set; }

        public string Value { get; set; }
    }
}