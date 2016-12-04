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

        //Global list of employee records
        List<AUTHENTICATION> userList = new List<AUTHENTICATION>();

        //initialise counts
        int countStaff = 0;
        int countManager = 0;

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

            //Check for any errors
            try
            {
                foreach (var user in dbEntities.AUTHENTICATIONs)
                {
                    //Add all users to the Global user list
                    userList.Add(user);
                }
            }
            //Report Errors
            catch (Exception)
            {
                //Display message error loading database
                MessageBox.Show("Problem loading user data from database");
                throw;
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
            //Get the Username from the tbxUserName.  Remove unnecessary spaces
            string currentUser = tbxUsername.Text.Trim();
            //Retrieve first 3 characters of Username
            string sub = currentUser.Substring(0,3);
            //Get password text.  Note it does not use he same syntax as a normal text box
            string currentPassword = passwordBox.Password;
            //Run the mtdGetUserDetails method with the inptted user name and password information
            userDetails = mtdGetUserDetails(currentUser, currentPassword);


            //Normal User
            if (userDetails.AccessLevel == 1)
            {
                this.Hide();
                ReservationMenu RsvMenu = new ReservationMenu();
                RsvMenu.Owner = this;
                RsvMenu.ShowDialog();
                //initialise count
                int count = 0;
            }

            //Management
            if (userDetails.AccessLevel == 2)
            {
                this.Hide();
                ManagementMenu ManMenu = new ManagementMenu();
                ManMenu.Owner = this;
                ManMenu.ShowDialog();
                //initialise count
                int count = 0;
            }

            //Other
            else
            {
                //Start Count
                countStaff++;

                //Normal user
                //First attempt
                if (sub == "STF" && countStaff == 1)
                {
                    lblMessage.Content = "Username and Password invalid, please try again";
                    tbxUsername.Text = "";
                    passwordBox.Password = "";
                    tbxUsername.Focus();
                }

                //Second attempt
                if (sub == "STF" && countStaff == 2)
                {
                    lblMessage.Content = "Username and Password invalid, One more try";
                    tbxUsername.Text = "";
                    passwordBox.Password = "";
                    tbxUsername.Focus();
                }

                //Third attempt
                if (sub == "STF" && countStaff == 3 || sub == "STF" && countStaff > 3)
                {
                    lblMessage.Content = "Username and Password invalid, please contact the administrator";
                    tbxUsername.IsEnabled = false;
                    passwordBox.IsEnabled = false;
                    tbxUsername.Focus();
                }

                //Start Count
                countManager++;

                //Manager
                //First attempt
                if (sub == "MGR" && countManager == 1)
                {
                    lblMessage.Content = "Username and Password invalid, please try again";
                    tbxUsername.Text = "";
                    passwordBox.Password = "";
                    tbxUsername.Focus();
                }

                //Second attempt
                if (sub == "MGR" && countManager == 2)
                {
                    lblMessage.Content = "Username and Password invalid, One more try";
                    tbxUsername.Text = "";
                    passwordBox.Password = "";
                    tbxUsername.Focus();
                }
                //Third attempt
                if (sub == "MGR" && countManager == 3 || sub == "MGR" && countManager > 3)
                {
                    lblMessage.Content = "Reset Password";
                    tbxUsername.Text = "";
                    passwordBox.Password = "";
                    tbxUsername.Focus();
                    btnResetPassword.Visibility = Visibility.Visible;
                    countManager = 0;
                }

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
