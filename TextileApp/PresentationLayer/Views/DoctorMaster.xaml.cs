﻿using System;
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

namespace MedicalApp.Views
{
    /// <summary>
    /// Interaction logic for DoctorMaster.xaml
    /// </summary>
    public partial class DoctorMaster : Window
    {
        public DoctorMaster()
        {
            InitializeComponent();
            DoctorMasterViewModels objViewModels = new DoctorMasterViewModels();
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
