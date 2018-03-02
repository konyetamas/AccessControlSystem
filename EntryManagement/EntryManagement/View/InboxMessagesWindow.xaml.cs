﻿using EntryManagement.BL;
using EntryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EntryManagement.View
{
    /// <summary>
    /// Interaction logic for MessagesWindow.xaml
    /// </summary>
    public partial class MessagesWindow : Window
    {

        InboxMessagesWindowViewModel VM = null;
        INboxMessagesWindowBL BL;
        public MessagesWindow()
        {
            InitializeComponent();

            if (VM == null)
            {
                VM = new InboxMessagesWindowViewModel();
                this.DataContext = VM;
            }
            BL = new INboxMessagesWindowBL();
            BL.InitMessagesFromCompanyList(VM.Messages);
        }
    }
}
