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
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        TestViewModel VM;
        public TestWindow()
        {
            InitializeComponent();
            if(VM==null)
            {
                VM = new TestViewModel();
                this.DataContext = VM;
            }

            VM.TestList = new System.Collections.ObjectModel.ObservableCollection<Model.CompanyModel>() { new CompanyModel() { Id = 0, Name = "oké" } };
        }
    }
}
