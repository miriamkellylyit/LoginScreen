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
        //Access database
        MKSQLDatabaseEntities dbEntities = new MKSQLDatabaseEntities();

        GUEST newGuest = new GUEST();

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

            mtdCreateGuest(newGuest);
        }

    //Create Guest
    public void mtdCreateGuest(GUEST guest)
        {
            try
            {
                guest.GuestID = Guid.NewGuid().ToString();
                
                    guest.FirstName = tbxFirstName.Text;
                    guest.SurName = tbxSurname.Text;
                    guest.AddressLine1 = tbxAddressLine1.Text;
                    guest.AddressLine2 = tbxAddressLine2.Text;
                    guest.Town = tbxTown.Text;
                    guest.County = tbxCounty.Text;
                    guest.Country = tbxCountry.Text;
                    guest.PostCode = tbxPostCode.Text;
                    guest.Email = tbxEmail.Text;
                    guest.Phone = tbxPhone.Text;
                    MessageBox.Show("Guest Created");

                dbEntities.Configuration.AutoDetectChangesEnabled = false;
                dbEntities.Configuration.ValidateOnSaveEnabled = false;
                dbEntities.Entry(guest).State = System.Data.Entity.EntityState.Added;
                dbEntities.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Problem Creating this record");
            }
        }

        private void tbxPostCode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxCountry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxCounty_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxTown_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxSurname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxAddressLine1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxAddressLine2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}


