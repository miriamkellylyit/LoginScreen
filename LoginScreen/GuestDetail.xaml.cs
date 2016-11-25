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
    /// Interaction logic for GuestDetail.xaml
    /// </summary>
    public partial class GuestDetail : Window
    {
        public GuestDetail()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ReservationDetail RsvDetail = new ReservationDetail();
            RsvDetail.Owner = this;
            RsvDetail.ShowDialog();
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Payment PaymentScrn = new Payment();
            PaymentScrn.Owner = this;
            PaymentScrn.ShowDialog();
        }

        private void btnExistingCustomer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
