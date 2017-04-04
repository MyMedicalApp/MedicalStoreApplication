using MedicalApp.ViewModels;
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

namespace TextileApp.Views
{
    /// <summary>
    /// Interaction logic for BatchNumber.xaml
    /// </summary>
    public partial class BatchNumber : Window
    {
        public BatchNumber()
        {
            InitializeComponent();
            BatchMasterViewModel batchMasterViewModel = new BatchMasterViewModel();
            this.DataContext = batchMasterViewModel;
            this.BatchNumberGridView.Focus();
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void BatchNumberGridView_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}
