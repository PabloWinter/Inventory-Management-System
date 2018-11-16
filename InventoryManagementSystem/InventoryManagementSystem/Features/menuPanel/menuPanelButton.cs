using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Features.menuPanel
{
    public partial class menuPanelButton : UserControl
    {
        public bool buttonSelected = false;

        public menuPanelButton()
        {
            InitializeComponent();
        }

        //mouse enter
        private void menuPanelButton_MouseEnter(object sender, EventArgs e)
        {
            if(!buttonSelected)
            this.BackColor = Color.SteelBlue;
        }


        //mouse leave
        private void menuPanelButton_MouseLeave(object sender, EventArgs e)
        {
            if(!buttonSelected)
            this.BackColor = Color.DodgerBlue;
        }


        //button text
        [
          Category("Data"),
          Description("Button label")
        ]
        public string Label1Text
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        }

        [
       Category("Data"),
       Description("Button icon emoji")
     ]
        public string Label2Text
        {
            get
            {
                return label2.Text;
            }

            set
            {
                label2.Text = value;
            }
        }


        //selection


        public void selectMenu (bool selected)
        {
            if (!selected)
            {
                buttonSelected = false;
                this.BackColor = Color.DodgerBlue;
            }
            else
            {
                buttonSelected = true;
                this.BackColor = Color.DimGray;
            }
        }

        private void menuPanelButton_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            if (!buttonSelected)
            this.BackColor = Color.SteelBlue;
        }
    }
}
