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

namespace LoginScreen
{
    /// <summary>
    /// Interaction logic for CheckOut.xaml
    /// </summary>
    public partial class CheckOut : Window
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReservationMenu RsvMenu = new ReservationMenu();
            RsvMenu.Owner = this;
            RsvMenu.ShowDialog();
        }

        private void btnRequestHousekeep_Click(object sender, RoutedEventArgs e)
        {
            //Update Room Status on Database

            //Check system time against check out time

            //If system time is greater than check out time
            //Display message with outstanding balance

        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Payment PaymentScrn = new Payment();
            PaymentScrn.Owner = this;
            PaymentScrn.ShowDialog();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            //Update Database

            //Send out confirmation email

            //Return to Reservation Menu
            this.Hide();
            ReservationMenu RsvMenu = new ReservationMenu();
            RsvMenu.Owner = this;
            RsvMenu.ShowDialog();
        }
    }
}
