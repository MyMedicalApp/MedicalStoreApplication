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
 using System.Windows.Navigation;
 using System.Windows.Shapes;
 
 namespace TextileApp.Views
 {
    /// <summary>
    /// Interaction logic for MstCompany.xaml
    /// </summary>
    public partial class MstCompany : Window
    {
        public MstCompany()
        {
            InitializeComponent();
        }
 
        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
 }
    
