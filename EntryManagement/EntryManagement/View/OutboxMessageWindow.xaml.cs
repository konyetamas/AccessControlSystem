﻿using System;
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
using EntryManagement.BL;
using EntryManagement.ViewModel;
using EntryManagement.View;

namespace EntryManagement.View
{
    /// <summary>
    /// Interaction logic for OutboxMessageWindow.xaml
    /// </summary>
    public partial class OutboxMessageWindow : Window
    {

        OutboxMessageWindowViewModel VM = null;
        MessagesWindowBL BL;
        public OutboxMessageWindow()
        {
            InitializeComponent();

            if (VM == null)
            {
                VM = new OutboxMessageWindowViewModel();
                this.DataContext = VM;
                VM.Messages = new System.Collections.ObjectModel.ObservableCollection<Model.MessageToCompanyModel>();

            }
            BL = new MessagesWindowBL();
        }

        private void AddNewMessageButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                AddNewMessage anmw = new AddNewMessage();
                anmw.ShowDialog();
                VM.Messages.Clear();
                BL.InitMessagesFromBuliding(VM.Messages);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MessagesListView_Loaded(object sender, RoutedEventArgs e)
        {
            BL.InitMessagesFromBuliding(VM.Messages);
        }
    }
}
