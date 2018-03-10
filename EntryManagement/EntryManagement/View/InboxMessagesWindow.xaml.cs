using EntryManagement.BL;
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
    public partial class InboxMessagesWindow : Window
    {

        InboxMessagesWindowViewModel VM = null;
        InboxMessagesWindowBL BL;
        public InboxMessagesWindow()
        {
            InitializeComponent();

            if (VM == null)
            {
                VM = new InboxMessagesWindowViewModel();
              
                VM.Messages = new System.Collections.ObjectModel.ObservableCollection<Model.MessageFromCompanyModel>();
                this.DataContext = VM;
            }
            BL = new InboxMessagesWindowBL();          
           
        }

        private void MessagesListView_Loaded(object sender, RoutedEventArgs e)
        {
            BL.InitMessagesFromCompanyList(VM.Messages);
        }
    }
}
