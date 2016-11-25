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
    /// Interaction logic for ReservationAmendment.xaml
    /// </summary>
    public partial class ReservationAmendment : Window
    {
        public ReservationAmendment()
        {
            InitializeComponent();
        }

        //Exit
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReservationMenu RsvMenu = new ReservationMenu();
            RsvMenu.Owner = this;
            RsvMenu.ShowDialog();
        }

        //Update
       private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //Update Database with detail from Reservation Amendment Screen
        }

        //Check Availability
        private void btnCheckAvailability_Click(object sender, RoutedEventArgs e)
        {
            //Go to Database and check for rooms available for New dates entered
        }
    }
}
