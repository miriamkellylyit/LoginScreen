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
    /// Interaction logic for AdministrationMenu.xaml
    /// </summary>
    public partial class AdministrationMenu : Window
    {
        public AdministrationMenu()
        {
            InitializeComponent();
        }

        //Exit
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Go to Management Menu
            this.Hide();
            ManagementMenu ManMenu = new ManagementMenu();
            ManMenu.Owner = this;
            ManMenu.ShowDialog();
        }

        private void btnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            //Go to User Detail Screen
        }

        private void btnUpdateUser_Click(object sender, RoutedEventArgs e)
        {
            //Go to Search User Screen
            this.Hide();
            SearchUser SearchUsr = new SearchUser();
            SearchUsr.Owner = this;
            SearchUsr.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            //Go to Search User Screen
            this.Hide();
            SearchUser SearchUsr = new SearchUser();
            SearchUsr.Owner = this;
            SearchUsr.ShowDialog();
        }

        private void btnResetPassword_Click(object sender, RoutedEventArgs e)
        {
            //Go to Password Screen
            this.Hide();
            Password PasswordScrn = new Password();
            PasswordScrn.Owner = this;
            PasswordScrn.ShowDialog();
        }
    }
}
