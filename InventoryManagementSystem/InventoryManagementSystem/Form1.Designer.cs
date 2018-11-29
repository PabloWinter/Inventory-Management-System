namespace InventoryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logisticOption = new InventoryManagementSystem.Features.menuPanel.menuPanelButton();
            this.plOption = new InventoryManagementSystem.Features.menuPanel.menuPanelButton();
            this.searchOption = new InventoryManagementSystem.Features.menuPanel.menuPanelButton();
            this.returnedOption = new InventoryManagementSystem.Features.menuPanel.menuPanelButton();
            this.stockOption = new InventoryManagementSystem.Features.menuPanel.menuPanelButton();
            this.categoryOption = new InventoryManagementSystem.Features.menuPanel.menuPanelButton();
            this.brandOption = new InventoryManagementSystem.Features.menuPanel.menuPanelButton();
            this.productOption = new InventoryManagementSystem.Features.menuPanel.menuPanelButton();
            this.dashboardOption = new InventoryManagementSystem.Features.menuPanel.menuPanelButton();
            this.optionTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.searchContent1 = new InventoryManagementSystem.Features.SearchTab.SearchContent();
            this.menuPanel.SuspendLayout();
            this.optionTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuPanel.Controls.Add(this.logisticOption);
            this.menuPanel.Controls.Add(this.plOption);
            this.menuPanel.Controls.Add(this.searchOption);
            this.menuPanel.Controls.Add(this.returnedOption);
            this.menuPanel.Controls.Add(this.stockOption);
            this.menuPanel.Controls.Add(this.categoryOption);
            this.menuPanel.Controls.Add(this.brandOption);
            this.menuPanel.Controls.Add(this.productOption);
            this.menuPanel.Controls.Add(this.dashboardOption);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(374, 1023);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.MouseLeave += new System.EventHandler(this.menuPanel_MouseLeave);
            // 
            // logisticOption
            // 
            this.logisticOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.logisticOption.Label1Text = "Logistics";
            this.logisticOption.Label2Text = "↙️↗️";
            this.logisticOption.Location = new System.Drawing.Point(0, 822);
            this.logisticOption.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.logisticOption.Name = "logisticOption";
            this.logisticOption.Size = new System.Drawing.Size(374, 74);
            this.logisticOption.TabIndex = 8;
            this.logisticOption.Click += new System.EventHandler(this.logisticOption_Click);
            // 
            // plOption
            // 
            this.plOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.plOption.Label1Text = "Purchase Log";
            this.plOption.Label2Text = "📜";
            this.plOption.Location = new System.Drawing.Point(-2, 743);
            this.plOption.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.plOption.Name = "plOption";
            this.plOption.Size = new System.Drawing.Size(374, 74);
            this.plOption.TabIndex = 7;
            this.plOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plOption_MouseClick);
            // 
            // searchOption
            // 
            this.searchOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchOption.Label1Text = "Search";
            this.searchOption.Label2Text = "🔍";
            this.searchOption.Location = new System.Drawing.Point(-2, 665);
            this.searchOption.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.searchOption.Name = "searchOption";
            this.searchOption.Size = new System.Drawing.Size(374, 74);
            this.searchOption.TabIndex = 6;
            this.searchOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchOption_MouseClick);
            // 
            // returnedOption
            // 
            this.returnedOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.returnedOption.Label1Text = "Returned";
            this.returnedOption.Label2Text = "↙️";
            this.returnedOption.Location = new System.Drawing.Point(0, 586);
            this.returnedOption.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.returnedOption.Name = "returnedOption";
            this.returnedOption.Size = new System.Drawing.Size(374, 74);
            this.returnedOption.TabIndex = 5;
            this.returnedOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.returnedOption_MouseClick);
            // 
            // stockOption
            // 
            this.stockOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.stockOption.Label1Text = "Current Stock";
            this.stockOption.Label2Text = "📦";
            this.stockOption.Location = new System.Drawing.Point(0, 508);
            this.stockOption.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.stockOption.Name = "stockOption";
            this.stockOption.Size = new System.Drawing.Size(374, 74);
            this.stockOption.TabIndex = 4;
            this.stockOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stockOption_MouseClick);
            // 
            // categoryOption
            // 
            this.categoryOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.categoryOption.Label1Text = "Category";
            this.categoryOption.Label2Text = "🔖";
            this.categoryOption.Location = new System.Drawing.Point(0, 429);
            this.categoryOption.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.categoryOption.Name = "categoryOption";
            this.categoryOption.Size = new System.Drawing.Size(374, 74);
            this.categoryOption.TabIndex = 3;
            this.categoryOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.categoryOption_MouseClick);
            // 
            // brandOption
            // 
            this.brandOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.brandOption.Label1Text = "Brands";
            this.brandOption.Label2Text = "✨";
            this.brandOption.Location = new System.Drawing.Point(0, 351);
            this.brandOption.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.brandOption.Name = "brandOption";
            this.brandOption.Size = new System.Drawing.Size(374, 74);
            this.brandOption.TabIndex = 2;
            this.brandOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.brandOption_MouseClick);
            // 
            // productOption
            // 
            this.productOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.productOption.Label1Text = "Products";
            this.productOption.Label2Text = "🛍️";
            this.productOption.Location = new System.Drawing.Point(0, 272);
            this.productOption.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.productOption.Name = "productOption";
            this.productOption.Size = new System.Drawing.Size(374, 74);
            this.productOption.TabIndex = 1;
            this.productOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productOption_MouseClick);
            // 
            // dashboardOption
            // 
            this.dashboardOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.dashboardOption.Label1Text = "Dashboard";
            this.dashboardOption.Label2Text = "🏠";
            this.dashboardOption.Location = new System.Drawing.Point(-2, 194);
            this.dashboardOption.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dashboardOption.Name = "dashboardOption";
            this.dashboardOption.Size = new System.Drawing.Size(374, 74);
            this.dashboardOption.TabIndex = 0;
            this.dashboardOption.Click += new System.EventHandler(this.menuPanelButton1_Click);
            // 
            // optionTabs
            // 
            this.optionTabs.Controls.Add(this.tabPage1);
            this.optionTabs.Controls.Add(this.tabPage2);
            this.optionTabs.Controls.Add(this.tabPage3);
            this.optionTabs.Controls.Add(this.tabPage4);
            this.optionTabs.Controls.Add(this.tabPage5);
            this.optionTabs.Controls.Add(this.tabPage6);
            this.optionTabs.Controls.Add(this.tabPage7);
            this.optionTabs.Controls.Add(this.tabPage8);
            this.optionTabs.Controls.Add(this.tabPage9);
            this.optionTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionTabs.Location = new System.Drawing.Point(374, 0);
            this.optionTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optionTabs.Name = "optionTabs";
            this.optionTabs.SelectedIndex = 0;
            this.optionTabs.Size = new System.Drawing.Size(1123, 1023);
            this.optionTabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1115, 990);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1115, 990);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(1115, 990);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Brands";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(1115, 990);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Category";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Size = new System.Drawing.Size(1115, 990);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Current Stock";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage6.Size = new System.Drawing.Size(1115, 990);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Returned";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.searchContent1);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage7.Size = new System.Drawing.Size(1115, 990);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Search";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage8.Size = new System.Drawing.Size(1115, 990);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Purchase Logs";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 29);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage9.Size = new System.Drawing.Size(1115, 990);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Logistics";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // searchContent1
            // 
            this.searchContent1.Location = new System.Drawing.Point(0, 0);
            this.searchContent1.Name = "searchContent1";
            this.searchContent1.Size = new System.Drawing.Size(1115, 990);
            this.searchContent1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 1023);
            this.Controls.Add(this.optionTabs);
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.optionTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private Features.menuPanel.menuPanelButton dashboardOption;
        private Features.menuPanel.menuPanelButton productOption;
        private System.Windows.Forms.TabControl optionTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private Features.menuPanel.menuPanelButton brandOption;
        private Features.menuPanel.menuPanelButton categoryOption;
        private Features.menuPanel.menuPanelButton stockOption;
        private Features.menuPanel.menuPanelButton returnedOption;
        private Features.menuPanel.menuPanelButton searchOption;
        private Features.menuPanel.menuPanelButton plOption;
        private Features.menuPanel.menuPanelButton logisticOption;
        private Features.SearchTab.SearchContent searchContent1;
    }
}

