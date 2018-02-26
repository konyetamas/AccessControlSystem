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

namespace EntryManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //PreviewKeyDown += MainWindow_PreviewKeyDown;
            //KeyDown += MainWindow_KeyDown;
        }

        //private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        //{
          
        //}

        //private void MainWindow_PreviewKeyDown(object sender, KeyEventArgs e)              
        //    {

           
        //}


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

        }

        private void CompaniesButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
