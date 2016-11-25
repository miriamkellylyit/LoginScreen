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
    /// Interaction logic for HotelManagement.xaml
    /// </summary>
    public partial class HotelManagement : Window
    {
        public HotelManagement()
        {
            InitializeComponent();
        }

        private void btnUpdateRate_Click(object sender, RoutedEventArgs e)
        {
            //Update Current Rate for Room 

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Go to Management Menu
            this.Hide();
            ManagementMenu ManMenu = new ManagementMenu();
            ManMenu.Owner = this;
            ManMenu.ShowDialog();
        }
    }
}
