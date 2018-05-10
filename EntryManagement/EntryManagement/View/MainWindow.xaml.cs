using EntryManagement.BL;
using EntryManagement.DAL;
using EntryManagement.Model;
using EntryManagement.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using HardverControl;
using HardverControl.Model;

namespace EntryManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel VM;
        MainWindowBL BL;
        UserModel CurrentUser;
        HardverComponent hardver;

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        public MainWindow(UserModel user)
        {
            InitializeComponent();


            CurrentUser = user;
            if (VM == null)
            {
                VM = new MainWindowViewModel();
            }
            this.DataContext = VM;
            VM.Entries = new System.Collections.ObjectModel.ObservableCollection<EntryModel>();
            BL = new MainWindowBL();
            BL.InitEntriesList(VM.Entries);
            VM.UserFullName = CurrentUser.Name;

           
            VM.ActualMember = new HardverControl.Model.MemberModel();

            if(user.Role==0)
            {
                UsersButton.Visibility = Visibility.Visible;
            }
            hardver = new HardverComponent();

            Task t = new Task(() =>
            {
                hardver.Process();
            });
            t.Start();
            // test.UpdateEntriesListEvent += Test_UpdateEntriesListEvent;
            hardver.UpdateEntryWindow += Test_UpdateEntryWindow;

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
        }



        EntryWindow ew;




        private void Test_UpdateEntryWindow(object sender, EventArgs e)
        {
            dispatcherTimer.Start();

            Dispatcher.Invoke(() =>
            {
                ew = new EntryWindow((sender as AnswerFromHardverModel).ActualMember.Id);
                ew.Focusable = true;
                if ((sender as AnswerFromHardverModel).Enable)
                {
                    ew.UserNameLabel.Content = (sender as AnswerFromHardverModel).ActualMember.FirstName;
                    ew.CompanyLabel.Content = (sender as AnswerFromHardverModel).ActualMember.CompanyName;
                }
                else
                {
                    ew.MessageLabel.Visibility = Visibility.Visible;

                }

                ew.ShowDialog();
                BL.InitEntriesList(VM.Entries);
                EntriesListView.SelectedItem = EntriesListView.Items[0];
            });
           

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            ew.Close();
            dispatcherTimer.Stop();
            BL.InitEntriesList(VM.Entries);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {

            base.OnKeyDown(e);
        }

        protected override void OnPreviewGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
        {
            base.OnPreviewGotKeyboardFocus(e);
        }

        private void MessagesButtonClick(object sender, RoutedEventArgs e)
        {
            InboxMessagesWindow imw = new InboxMessagesWindow();
            imw.ShowDialog();
        }

        private void CompaniesButtonClick(object sender, RoutedEventArgs e)
        {
            CompaniesWindow cw = new CompaniesWindow(CurrentUser.Role);
            cw.ShowDialog();
        }

        private void OutboxMessagesClick(object sender, RoutedEventArgs e)
        {
            OutboxMessageWindow omw = new OutboxMessageWindow();
            omw.ShowDialog();
        }

        private void UsersButton_Click(object sender, RoutedEventArgs e)
        {
            UsersWindow window = new UsersWindow();
            window.ShowDialog();
        }

        private void OpenDoorButton_Click(object sender, RoutedEventArgs e)
        {
            hardver.DoorManagement(true);
        }
    }


}
