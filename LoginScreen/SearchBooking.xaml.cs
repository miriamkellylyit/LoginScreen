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
    /// Interaction logic for SearchBooking.xaml
    /// </summary>
    public partial class SearchBooking : Window
    {
        public SearchBooking()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Hide this screen
            this.Hide();
            //Go to Reservation Menu
            ReservationMenu RsvMenu = new ReservationMenu();
            RsvMenu.Owner = this;
            RsvMenu.ShowDialog();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //Go off to Database to find record

            //Populate the Reservation Amendment Screen

            //Display the Reservation Amendment Screen
            ReservationAmendment RsvAmend = new ReservationAmendment();
            RsvAmend.Owner = this;
            RsvAmend.ShowDialog();
        }
    }
}
