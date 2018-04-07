using EntryManagement.BL;
using EntryManagement.Model;
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
    /// Interaction logic for AddNewCompanyWindow.xaml
    /// </summary>
    public partial class AddNewCompanyWindow : Window
    {
        AddNewCompanyWindowBL BL;
        public AddNewCompanyWindow()
        {
            InitializeComponent();
            BL = new AddNewCompanyWindowBL();
        }

        private void AddNewCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CompanyModel model = new CompanyModel();
                model.Name = CompanyNametextBox.Text;
                model.Address = CompanyAddresstextBox.Text;
                model.Phone = CompanyPhonetextBox.Text;
                BL.AddNewCompany(model);
                this.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
