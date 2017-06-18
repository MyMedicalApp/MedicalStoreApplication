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
using MedicalApp.ViewModels;
using MedicalApp.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls.Primitives;

namespace MedicalApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent(); 
        }
       
        private void AccountMasterMenuItem_Click(object sender, RoutedEventArgs e)
        {
            //AccountWindow accountWindow = new AccountWindow();
            //accountWindow.ShowDialog();
            //accountWindow.txtAccountCode.Focus();
        }
         
        #region "Masters"
        private void DoctorMasterMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DoctorMaster MstCompanyDetail = new DoctorMaster();
            MstCompanyDetail.ShowDialog();
        }

        private void GenericMasterMenuItem_Click(object sender, RoutedEventArgs e)
        {
            GenericMaster MstCompanyDetail = new GenericMaster();
            MstCompanyDetail.ShowDialog();
        }
        #endregion "Masters"

        #region "Transaction"
        private void SaleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new SalesBill();
        }
        #endregion "Transaction"

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.F2)
            {
                ((SalesBill)(mainFrame.NavigationService.Content)).SalesGridView.Focus();
            }
        }
    }
}
