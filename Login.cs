using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;

namespace ROVER
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public bool IsAuthenticated(string srv, string usr, string pass)
        {
            bool authenticated = false;
            try
            {
                DirectoryEntry entry = new DirectoryEntry(srv, usr, pass);
                object nativeObject = entry.NativeObject;
                authenticated = true;
            }
            catch (DirectoryServicesCOMException cex)
            {
                //does not work
            }
            catch (Exception ex)
            {
                //does not work
            }
            return authenticated;
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {

            string server = "LDAP://politie.oost";
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (IsAuthenticated(server, username, password) == true)
            {
              //  MessageBox.Show(username + " is logged in");
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                MessageBox.Show("foute wagwoord chef");
            }
            UsernameControl.Username = txtUsername.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
