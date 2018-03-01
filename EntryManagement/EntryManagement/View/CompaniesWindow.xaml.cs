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
    /// Interaction logic for CompaniesWindow.xaml
    /// </summary>
    public partial class CompaniesWindow : Window
    {
        CompaniesWindowViewModel VM = null;
        CompaniesWindowBL BL;
        public CompaniesWindow()
        {
            InitializeComponent();
            if (VM==null)
            {
                VM = new CompaniesWindowViewModel();
                this.DataContext = VM;
            }
            BL = new CompaniesWindowBL();
            BL.InitCompaniesList(VM.Companies);           
        }

        private void CompaniesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BL.InitMembersOfCompanyList(VM.MembersOfSelectedCompany, VM.SelectedCompany.Id);
        }
    }
}
