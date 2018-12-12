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
    public partial class MainInventoryForm : Form
    {
        public MainInventoryForm()
        {
            InitializeComponent();

            menuPanel.Width = 249;
            SelectOption("Dashboard");           
        }

        //selection menu option
        public void SelectOption(string option)
        {
            foreach (InventoryManagementSystem.Features.menuPanel.menuPanelButton C in menuPanel.Controls)
            {
               if (C.Label1Text != option)
               {
                    C.selectMenu(false);
               }

               else
               {
                    C.selectMenu(true);
               }
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //hide the tabs so buttons are used to navigate
             optionTabs.Appearance = TabAppearance.FlatButtons;
             //optionTabs.ItemSize = new Size(0, 1);
             //optionTabs.SizeMode = TabSizeMode.Fixed;
        }


        //expand/small menu panel
        private void menuPanel_MouseEnter(object sender, EventArgs e)
        {
           // menuPanel.Width = 249;
        }

        private void menuPanel_MouseLeave(object sender, EventArgs e)
        {
            //menuPanel.Width = 79;
        }



        //clicks

        //click dashboard button
        private void menuPanelButton1_Click(object sender, EventArgs e)
        {
            SelectOption("Dashboard");
            optionTabs.SelectedIndex = 0;
        }

        //products click
        private void productOption_MouseClick(object sender, MouseEventArgs e)
        {
            SelectOption("Products");
            optionTabs.SelectedIndex = 1;
        }


        //brands click
        private void brandOption_MouseClick(object sender, MouseEventArgs e)
        {
            SelectOption("Brands");
            optionTabs.SelectedIndex = 2;
        }

        //category click
        private void categoryOption_MouseClick(object sender, MouseEventArgs e)
        {
            SelectOption("Category");
            optionTabs.SelectedIndex = 3;
        }

        //current stock
        private void stockOption_MouseClick(object sender, MouseEventArgs e)
        {
            SelectOption("Current Stock");
            optionTabs.SelectedIndex = 4;
        }

        //returned
        private void returnedOption_MouseClick(object sender, MouseEventArgs e)
        {
            SelectOption("Returned");
            optionTabs.SelectedIndex = 5;
        }

        //search
        private void searchOption_MouseClick(object sender, MouseEventArgs e)
        {
            SelectOption("Search");
            optionTabs.SelectedIndex = 6;
        }

        //purchase logs
        private void plOption_MouseClick(object sender, MouseEventArgs e)
        {
            SelectOption("Purchase Log");
            optionTabs.SelectedIndex = 7;
        }
        
        private void locationOption_Click(object sender, EventArgs e)
        {
            SelectOption("Location");
            optionTabs.SelectedIndex = 9;
        }
    }
}
