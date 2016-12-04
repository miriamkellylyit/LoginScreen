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
    /// Interaction logic for ReservationDetail.xaml
    /// </summary>
    public partial class ReservationDetail : Window
    {
        MKSQLDatabaseEntities dbEntities = new MKSQLDatabaseEntities();

        public ReservationDetail()
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

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            GuestDetail GuestDtl = new GuestDetail();
            GuestDtl.Owner = this;
            GuestDtl.ShowDialog();
        }

        private void btnCheckAvailability_Click(object sender, RoutedEventArgs e)
        {
            ROOM freeRoom = new ROOM();
            DateTime fromDate = dateFromDate.SelectedDate.Value;
            DateTime toDate = dateToDate.SelectedDate.Value;
            string roomType = ((ComboBoxItem)cbxRoomType.SelectedItem).Content.ToString();


            //Check Room Type has Status "Unoccupied"
            foreach (var room in dbEntities.ROOMs)
            {
                if (roomType == "Double" && room.RoomStatus == "Unoccupied")
                {

                //Check ReservationID blank - Return RoomID Free

                if (room.ReservationID == "" || room.ReservationID == null) 
                    {
                    lblMessageLine.Content= ("Room " + room.RoomID.TrimEnd()  + " is available for " + room.CurrentRate +" Euro");
                        return;
                    }

                    //If ReservationID populated 
                    //Check InputDateFrom < FileDateFrom AND InputDateTo < FileDateTo - Room Free
                    else
                    {

                        foreach (var reservation in dbEntities.RESERVATIONs)
                        {
                            // double dateRange = (toDate - fromDate).Days;
           
                            if ((fromDate < reservation.FromDate && toDate < reservation.ToDate))
                            {
                                MessageBox.Show ("RoomID Free");
                            }

                        }
                    }
                }

            }

            //    foreach (var reservation in dbEntities.RESERVATIONs)
            //    {
            //        double dateRange = (toDate - fromDate).Days;
            //        if (!(reservation.FromDate == fromDate))
            //        {
            //        }
            //    }


        }

        private void cbxRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
