﻿using EntryManagement.BL;
using EntryManagement.Model;
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
    /// Interaction logic for CompaniesWindow.xaml
    /// </summary>
    public partial class CompaniesWindow : Window
    {
        CompaniesWindowViewModel VM = null;
        CompaniesWindowBL BL;
        public CompaniesWindow(int UserRole)
        {
            InitializeComponent();
            if (VM==null)
            {
                VM = new CompaniesWindowViewModel();
                this.DataContext = VM;
                VM.MembersOfSelectedCompany = new System.Collections.ObjectModel.ObservableCollection<MemberModel>();
                VM.Companies = new System.Collections.ObjectModel.ObservableCollection<CompanyModel>();
            }
         
            BL = new CompaniesWindowBL();
          

        }

        private void CompaniesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BL.InitMembersOfCompanyList(VM.MembersOfSelectedCompany, VM.SelectedCompany.Id);
        }

        private void MembersOfCompanyListView_Initialized(object sender, EventArgs e)
        {

           // VM.Companies.Add(new CompanyModel() { Id = 1, Name = "TExt" });
            BL.InitCompaniesList(VM.Companies);
            
        }

        private void AddNewCompanyButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
