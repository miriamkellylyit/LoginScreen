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
    /// Interaction logic for ReservationMenu.xaml
    /// </summary>
    public partial class ReservationMenu : Window
    {
        public ReservationMenu()
        {
            InitializeComponent();
        }

        private void btnCreateReservation_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReservationDetail RsvDetail = new ReservationDetail();
            RsvDetail.Owner = this;
            RsvDetail.ShowDialog();
        }

        private void btnUpdateReservation_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchBooking SearchBK = new SearchBooking();
            SearchBK.Owner = this;
            SearchBK.ShowDialog();
        }

        private void btnCancelReservation_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReservationCancel RsvCancel = new ReservationCancel();
            RsvCancel.Owner = this;
            RsvCancel.ShowDialog();
        }

        private void btnCheckOut_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
            CheckOut ChkOut = new CheckOut();
            ChkOut.Owner = this;
            ChkOut.ShowDialog();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow Login = new MainWindow();
            Login.Owner = this;
            Login.ShowDialog();
        }
    }
}
