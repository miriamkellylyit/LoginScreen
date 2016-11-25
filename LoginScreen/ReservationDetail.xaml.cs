﻿using System;
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

namespace LoginScreen
{
    /// <summary>
    /// Interaction logic for ReservationDetail.xaml
    /// </summary>
    public partial class ReservationDetail : Window
    {
        public ReservationDetail()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            GuestDetail GuestDtl = new GuestDetail();
            GuestDtl.Owner = this;
            GuestDtl.ShowDialog();
        }
    }
}
