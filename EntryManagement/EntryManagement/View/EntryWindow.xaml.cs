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
    /// Interaction logic for EntryWindow.xaml
    /// </summary>
    public partial class EntryWindow : Window
    {
        EntryWindowViewModel VM;
        EntryWindowBL BL;
        public EntryWindow(int UserId)
        {
            InitializeComponent();
            if(VM==null)
            {
                VM = new EntryWindowViewModel();              
            }
            this.DataContext = VM;
            BL = new EntryWindowBL();
            VM.ImageSource = BL.GetImgUrl(UserId);
        }
    }
}
