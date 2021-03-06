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
    /// Interaction logic for AddNewMessage.xaml
    /// </summary>
    public partial class AddNewMessage : Window
    {
        AddNewMessageWindowViewModel VM;
        AddNewMessageBL BL;
        public AddNewMessage()
        {
            InitializeComponent();
            if(VM==null)
            {
                VM = new AddNewMessageWindowViewModel();
                this.DataContext = VM;
                VM.Companies = new System.Collections.ObjectModel.ObservableCollection<CompanyModel>();
                VM.AddedCompanies = new System.Collections.ObjectModel.ObservableCollection<CompanyModel>();
            }
            BL = new AddNewMessageBL();
        }

        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            BL.InitCompaniesList(VM.Companies);
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                VM.AddedCompanies.Add(VM.SelectedCompany);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                MessagesFromBulidingModel model = new MessagesFromBulidingModel();
                model.Companies = VM.AddedCompanies.ToList();
                model.Subject = SubjectTextBox.Text;
                model.Text = ValueTextBox.Text;
                BL.AddNewMessages(model);
                VM.AddedCompanies.Clear();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
