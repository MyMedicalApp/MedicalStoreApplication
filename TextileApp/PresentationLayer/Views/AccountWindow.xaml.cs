using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TextileApp.ViewModels;

namespace TextileApp
{
    /// <summary>
    /// Interaction logic for AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        public AccountWindow()
        {
            InitializeComponent();

            AcountsGridView.SelectedIndex = 0;

            MstAccountMasterViewModels mstAccountMasterViewModels = new MstAccountMasterViewModels();
            this.txtGroup.AutoSuggestionList = mstAccountMasterViewModels.listAutoCompleteTextBoxData;            
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
