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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Database entity framework reference
        MKSQLDatabaseEntities dbEntities = new MKSQLDatabaseEntities();

        //Global list of user records
        List<AUTHENTICATION> userList = new List<AUTHENTICATION>();  

        public MainWindow()
        {
            InitializeComponent();
        }

        //Update Window_Loaded method to call MtdLoadUsers
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //pre-load users into the Global user list
            mtdLoadUser();
        }

        //Load the employees 
        private void mtdLoadUser()
        {
            //Clear contents of the Employee List
            userList.Clear();
            foreach (var user in userList)
            {
                //Add all users to the Global user list
                userList.Add(user);
            }
        }

        //Get Employee details
        private AUTHENTICATION mtdGetUserDetails(string Userid, string password)
        {
            AUTHENTICATION userDetails = new AUTHENTICATION();

            foreach (var user in userList)
            {
                //Check each user name and password in the global list to see if it matches
                //teh inputted user name and password
                if (Userid == user.Userid && password == user.Password)
                {
                    //If there is a match then add the details to the local user account
                    userDetails = user;
                }

            }

            //Return the user details
            return userDetails;
        }


        //Exit
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Continue
        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            //Create an instance of a user class
            AUTHENTICATION userDetails = new AUTHENTICATION();
            //Get the Username from teh tbxUserName.  Remove unnecessary spaces
            string currentUser = tbxUsername.Text.Trim();
            //Get password text.  Note it does not use he same syntax as a normal text box
            string currentPassword = passwordBox.Password;
            //Run the mtdGetUserDetails method with the inptted user name and password information
            userDetails = mtdGetUserDetails(currentUser, currentPassword);


            //Normal User
            if (userDetails.AccessLevel == "1")
            {
                this.Hide();
                ReservationMenu RsvMenu = new ReservationMenu();
                RsvMenu.Owner = this;
                RsvMenu.ShowDialog();
            }

            //Management
            if (userDetails.AccessLevel == "2")
            {
                this.Hide();
                ManagementMenu ManMenu = new ManagementMenu();
                ManMenu.Owner = this;
                ManMenu.ShowDialog();
            }

            //Other
            else
            {
               
                lblMessage.Content = "Invalid details";
                tbxUsername.Text = "";
                passwordBox.Password = "";
                tbxUsername.Focus();

            }
         
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
