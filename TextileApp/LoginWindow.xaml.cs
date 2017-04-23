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
using System.Configuration;

namespace MedicalApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            // Read the file as one string.
            //System.IO.StreamReader myFile = new System.IO.StreamReader("c:\\Textile.txt");
            //string myString = myFile.ReadToEnd();
            //myFile.Close();
            //Common.ConnctionSetting.ConStr = myString;    
            Common.ConnctionSetting.ConStr = "Data Source=RAJPUROHIT-PC;Initial Catalog=2016;User ID=sa;Password=hussain@123";   //;myString; 

            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }               
    }
}
