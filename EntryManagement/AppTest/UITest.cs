using EntryManagement;
using EntryManagement.DAL;
using EntryManagement.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;
//using Core.UIItems;
//using White.NUnit;

namespace AppTest
{
    [TestFixture]
    public class UITest
    {
        Application application;
        [SetUp]
        public void Init()
        {
            application= Application.Launch(@"C:\Users\Tomi\Source\Repos\AccessControlSystem\EntryManagement\EntryManagement\bin\Debug\EntryManagement.exe");
        }

        [Test]
        public void ApplicationTest()
        {
            Assert.IsNotNull(application);
        }

        [Test]
        public void FailedLoginTest()
        {
            Window window = application.GetWindow("LoginWindow");

            window.Get<TextBox>("LoginNameTextBox").SetValue("test");
            window.Get<TextBox>("PasswordBox").SetValue("test");

            window.Get<Button>("button").Click();
            Assert.That(window.IsCurrentlyActive, Is.True);
        }


        [Test]
        public void SuccessLoginTest()
        {
           Window window= application.GetWindow("LoginWindow");

            window.Get<TextBox>("LoginNameTextBox").SetValue("admin");
            window.Get<TextBox>("PasswordBox").SetValue("admin");

            window.Get<Button>("button").Click();
            Assert.That(window.IsCurrentlyActive, Is.False);
        }


        [Test]
        public void CompaniesWindowBasicTest()
        {
            SuccessLoginTest();
            Window window = application.GetWindow("MainWindow");
            window.Get<Button>("CompaniesButton").Click();

            Window compwindow = application.GetWindow("CompaniesWindow");

            CompanyDAL companyDAL = new CompanyDAL();
            int companyCount = companyDAL.GetCompanies().Count;
            ListView listview = compwindow.Get<ListView>("CompaniesListView");
            bool itemscheck= listview.Items.Count == companyCount;

            compwindow.Get<Button>("AddNewCompanyButton").Click();

            bool isactiveWindow = compwindow.IsCurrentlyActive == true;
            
            Assert.That(itemscheck && !isactiveWindow, Is.True);
        }

        [Test]
        public void CompaniesWindowFunctionalityTest()
        {
            SuccessLoginTest();
            Window window = application.GetWindow("MainWindow");
            window.Get<Button>("CompaniesButton").Click();

            Window compwindow = application.GetWindow("CompaniesWindow");

            
            ListView listview = compwindow.Get<ListView>("CompaniesListView");
            int listviewcount = listview.Items.Count;
            listview.Select(0);
            bool namelabelcheck = compwindow.Get<Label>("SelectedCompanyNameLabel").Text != "" && compwindow.Get<Label>("SelectedCompanyNameLabel").Text != null;
            bool memberslistviewCheck = compwindow.Get<ListView>("MembersOfCompanyListView").Items.Count > 0;

            compwindow.Get<Button>("AddNewCompanyButton").Click();
            Window addnewcompwindow = application.GetWindow("AddNewCompanyWindow");
            addnewcompwindow.Get<TextBox>("CompanyNametextBox").SetValue("test1");
            addnewcompwindow.Get<TextBox>("CompanyAddresstextBox").SetValue("test1");
            addnewcompwindow.Get<TextBox>("CompanyPhonetextBox").SetValue("test1");

            addnewcompwindow.Get<Button>("AddNewCompanyButton").Click();

            listview = compwindow.Get<ListView>("CompaniesListView");
            bool itemadded = listview.Items.Count - listviewcount == 1;
            int countbeforedelete = listview.Items.Count;
            listview.Select(listview.Items.Count-1);
            compwindow.Get<Button>("DeleteCompanyButton").Click();
            listview = compwindow.Get<ListView>("CompaniesListView");
            bool itemdeleted = countbeforedelete - listview.Items.Count == 1;
             Assert.That(namelabelcheck && memberslistviewCheck && itemadded && itemdeleted, Is.True);
        }

        [Test]
        public void InboxMessagesWindowBasicTest()
        {
            SuccessLoginTest();
            Window window = application.GetWindow("MainWindow");
            window.Get<Button>("InboxMessagesButton").Click();

            Window messageswindow = application.GetWindow("InboxMessagesWindow");

           
            ListView listview = messageswindow.Get<ListView>("MessagesListView");

            Assert.That(messageswindow.IsCurrentlyActive && listview!=null, Is.True);
        }

        [Test]
        public void OutboxMessageWindowBasicTest()
        {
            SuccessLoginTest();
            Window window = application.GetWindow("MainWindow");
            window.Get<Button>("OutboxMessagesButton").Click();

            Window messageswindow = application.GetWindow("OutboxMessageWindow");
            bool windowtest = messageswindow.IsCurrentlyActive;

            ListView listview = messageswindow.Get<ListView>("MessagesListView");
            bool listviewtest = listview != null;

            messageswindow.Get<Button>("AddNewMessageButton").Click();
            Window addnewmessagewindow = application.GetWindow("AddNewMessage");
            bool newmessageActive = addnewmessagewindow.IsCurrentlyActive;


            Assert.That(windowtest && listviewtest && newmessageActive, Is.True);
        }

        [Test]
        public void OutboxMessageWindowFunctionalityTest()
        {
            SuccessLoginTest();
            Window window = application.GetWindow("MainWindow");
            window.Get<Button>("OutboxMessagesButton").Click();

            Window messageswindow = application.GetWindow("OutboxMessageWindow");
            ListView listview = messageswindow.Get<ListView>("MessagesListView");
            int listviewcount = 0;
            bool labelcheck = true;
            if (listview.Items.Count>0)
            {
                 listviewcount = listview.Items.Count;
                listview.Select(0);
                labelcheck = messageswindow.Get<Label>("SelectedMessageSubjectLabel").Text != null && messageswindow.Get<Label>("SelectedMessageSubjectLabel").Text != "";

            }

            messageswindow.Get<Button>("AddNewMessageButton").Click();
            Window addnewmessagewindow = application.GetWindow("AddNewMessage");

            addnewmessagewindow.Get<ComboBox>("comboBox").Select(0);
            addnewmessagewindow.Get<Button>("AddButton").Click();
            addnewmessagewindow.Get<TextBox>("SubjectTextBox").SetValue("test");

            addnewmessagewindow.Get<Button>("SendButton").Click();
            listview = messageswindow.Get<ListView>("MessagesListView");

            bool itemadded = listview.Items.Count - listviewcount == 1;

            Assert.That(labelcheck && itemadded, Is.True);
        }


        [Test]
        public void UserWindowBasicTest()
        {
            SuccessLoginTest();
            Window window = application.GetWindow("MainWindow");
            window.Get<Button>("UsersButton").Click();

            Window userswindow = application.GetWindow("UsersWindow");

            ListView listview = userswindow.Get<ListView>("UsersListView");
            bool listviewcheck = listview.Items.Count > 0;

            userswindow.Get<Button>("AddNewUserButton").Click();
            Window addnewuserwindow = application.GetWindow("AddNewUserWindow");

            Assert.That(addnewuserwindow.IsCurrentlyActive && listviewcheck, Is.True);
        }

        //[Test]
        //public void UserWindowFunctionalityTest()
        //{
        //    SuccessLoginTest();
        //    Window window = application.GetWindow("MainWindow");
        //    window.Get<Button>("UsersButton").Click();

        //    Window userswindow = application.GetWindow("UsersWindow");

        //    ListView listview = userswindow.Get<ListView>("UsersListView");
        //    int listviewcount = listview.Items.Count;

        //    userswindow.Get<Button>("AddNewUserButton").Click();
        //    Window addnewuserwindow = application.GetWindow("AddNewUserWindow");

        //    addnewuserwindow.Get<TextBox>("UsertextBox").SetValue("test");
        //    addnewuserwindow.Get<TextBox>("PasswordTextBox").SetValue("test");
        //    addnewuserwindow.Get<ComboBox>("comboBox").Select(0);
        //    addnewuserwindow.Get<Button>("AddNewUserbutton").Click();

        //    listview = userswindow.Get<ListView>("UsersListView");
        //    bool useradded = listview.Items.Count - listviewcount == 1;
        //    int countbeforedeleted = listview.Items.Count;

        //    listview.Select(listview.Items.Count - 1);
        //    userswindow.Get<Button>("DeleteUserButton").Click();
        //    listview = userswindow.Get<ListView>("UsersListView");           
        //    bool userdeleted = countbeforedeleted - listview.Items.Count == 1;

        //    Assert.That(useradded && userdeleted, Is.True);
        //}
    }
}
