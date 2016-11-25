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
    /// Interaction logic for ManagementMenu.xaml
    /// </summary>
    public partial class ManagementMenu : Window
    {
        public ManagementMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Return to Login Screen
            this.Hide();
            MainWindow Login = new MainWindow();
            Login.Owner = this;
            Login.ShowDialog();
        }


        private void btnHotelManagement_Click(object sender, RoutedEventArgs e)
        {
            //Go to Hotel Management
            this.Hide();
            HotelManagement HotelMan = new HotelManagement();
            HotelMan.Owner = this;
            HotelMan.ShowDialog();
        }

        private void btnAdministration_Click(object sender, RoutedEventArgs e)
        {
            //Go to Administration Menu
            this.Hide();
            AdministrationMenu AdminMenu = new AdministrationMenu();
            AdminMenu.Owner = this;
            AdminMenu.ShowDialog();
        }
    }
}
