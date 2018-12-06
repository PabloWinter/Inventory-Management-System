using InventoryDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        // static string to store user email
        public static string SetManager = "";
        
        public LoginForm()
        {
            InitializeComponent();

            // password hash in textbox
            passwordTxt.PasswordChar = '*';
            passwordTxt.CharacterCasing = CharacterCasing.Lower;
        }

        private void BtnLoggin_Click(object sender, EventArgs e)
        {
            string userManager = emailTxt.Text;
            string passwordmanager = passwordTxt.Text;

            using (DataLinqToSQLDataContext user = new DataLinqToSQLDataContext())
            {
                // Getting managers table
                var managerTable = user.GetTable<TManagerInventory>();

                var authManager = managerTable.Where(x => x.ManagerEmail == userManager && x.Password == passwordmanager).ToList();

                // Checking if user is valid
                if (authManager.Count > 0)
                {
                    // This information is going to be sent to the main form
                    SetManager = emailTxt.Text;

                    MessageBox.Show("Welcome " + userManager, "Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.None);

                    MainInventoryForm authForm = new MainInventoryForm();
                    authForm.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("You enter wrong credentials!", "Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
