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
    /// Interaction logic for ReservationCancel.xaml
    /// </summary>
    public partial class ReservationCancel : Window
    {
        public ReservationCancel()
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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            //Go to Database and update Cancellation Date

        }
    }
}
