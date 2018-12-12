namespace InventoryManagementSystem
{
    partial class MainInventoryForm
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
            this.locationOption = new InventoryManagementSystem.Features.menuPanel.menuPanelButton();
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
            this.dashboard1 = new InventoryManagementSystem.Features.Dashboard.Dashboard();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.brandControl1 = new InventoryManagementSystem.Features.BrandTab.BrandControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.categoryControl1 = new InventoryManagementSystem.Features.CategoryTab.CategoryControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.stockManager1 = new InventoryManagementSystem.Features.Stock.StockManager();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.returnManager1 = new InventoryManagementSystem.Features.Return.ReturnManager();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.searchContent1 = new InventoryManagementSystem.Features.SearchTab.SearchContent();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.purchaseLogContent1 = new InventoryManagementSystem.Features.PurchaseLogTab.PurchaseLogContent();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.locationManager1 = new InventoryManagementSystem.Features.Location.LocationManager();
            this.productsControl1 = new InventoryManagementSystem.Features.ProductTab.ProductsControl();
            this.menuPanel.SuspendLayout();
            this.optionTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuPanel.Controls.Add(this.locationOption);
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
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(332, 817);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.MouseLeave += new System.EventHandler(this.menuPanel_MouseLeave);
            // 
            // locationOption
            // 
            this.locationOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.locationOption.Label1Text = "Location";
            this.locationOption.Label2Text = "🗺️";
            this.locationOption.Location = new System.Drawing.Point(0, 532);
            this.locationOption.Margin = new System.Windows.Forms.Padding(5);
            this.locationOption.Name = "locationOption";
            this.locationOption.Size = new System.Drawing.Size(332, 59);
            this.locationOption.TabIndex = 9;
            this.locationOption.Click += new System.EventHandler(this.locationOption_Click);
            // 
            // plOption
            // 
            this.plOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.plOption.Label1Text = "Purchase Log";
            this.plOption.Label2Text = "📜";
            this.plOption.Location = new System.Drawing.Point(-1, 656);
            this.plOption.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.plOption.Name = "plOption";
            this.plOption.Size = new System.Drawing.Size(332, 59);
            this.plOption.TabIndex = 7;
            this.plOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plOption_MouseClick);
            // 
            // searchOption
            // 
            this.searchOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchOption.Label1Text = "Search";
            this.searchOption.Label2Text = "🔍";
            this.searchOption.Location = new System.Drawing.Point(-1, 594);
            this.searchOption.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchOption.Name = "searchOption";
            this.searchOption.Size = new System.Drawing.Size(332, 59);
            this.searchOption.TabIndex = 6;
            this.searchOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchOption_MouseClick);
            // 
            // returnedOption
            // 
            this.returnedOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.returnedOption.Label1Text = "Returned";
            this.returnedOption.Label2Text = "↙️";
            this.returnedOption.Location = new System.Drawing.Point(0, 469);
            this.returnedOption.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.returnedOption.Name = "returnedOption";
            this.returnedOption.Size = new System.Drawing.Size(332, 59);
            this.returnedOption.TabIndex = 5;
            this.returnedOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.returnedOption_MouseClick);
            // 
            // stockOption
            // 
            this.stockOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.stockOption.Label1Text = "Current Stock";
            this.stockOption.Label2Text = "📦";
            this.stockOption.Location = new System.Drawing.Point(0, 406);
            this.stockOption.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.stockOption.Name = "stockOption";
            this.stockOption.Size = new System.Drawing.Size(332, 59);
            this.stockOption.TabIndex = 4;
            this.stockOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stockOption_MouseClick);
            // 
            // categoryOption
            // 
            this.categoryOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.categoryOption.Label1Text = "Category";
            this.categoryOption.Label2Text = "🔖";
            this.categoryOption.Location = new System.Drawing.Point(0, 343);
            this.categoryOption.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.categoryOption.Name = "categoryOption";
            this.categoryOption.Size = new System.Drawing.Size(332, 59);
            this.categoryOption.TabIndex = 3;
            this.categoryOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.categoryOption_MouseClick);
            // 
            // brandOption
            // 
            this.brandOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.brandOption.Label1Text = "Brands";
            this.brandOption.Label2Text = "✨";
            this.brandOption.Location = new System.Drawing.Point(0, 281);
            this.brandOption.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.brandOption.Name = "brandOption";
            this.brandOption.Size = new System.Drawing.Size(332, 59);
            this.brandOption.TabIndex = 2;
            this.brandOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.brandOption_MouseClick);
            // 
            // productOption
            // 
            this.productOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.productOption.Label1Text = "Products";
            this.productOption.Label2Text = "🛍️";
            this.productOption.Location = new System.Drawing.Point(0, 218);
            this.productOption.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.productOption.Name = "productOption";
            this.productOption.Size = new System.Drawing.Size(332, 59);
            this.productOption.TabIndex = 1;
            this.productOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productOption_MouseClick);
            // 
            // dashboardOption
            // 
            this.dashboardOption.BackColor = System.Drawing.Color.DodgerBlue;
            this.dashboardOption.Label1Text = "Dashboard";
            this.dashboardOption.Label2Text = "🏠";
            this.dashboardOption.Location = new System.Drawing.Point(-1, 155);
            this.dashboardOption.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dashboardOption.Name = "dashboardOption";
            this.dashboardOption.Size = new System.Drawing.Size(332, 59);
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
            this.optionTabs.Controls.Add(this.tabPage10);
            this.optionTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionTabs.Location = new System.Drawing.Point(332, 0);
            this.optionTabs.Margin = new System.Windows.Forms.Padding(4);
            this.optionTabs.Name = "optionTabs";
            this.optionTabs.SelectedIndex = 0;
            this.optionTabs.Size = new System.Drawing.Size(999, 817);
            this.optionTabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dashboard1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(991, 788);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            // 
            // dashboard1
            // 
            this.dashboard1.AutoScroll = true;
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(5);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(991, 788);
            this.dashboard1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.productsControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(991, 788);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.brandControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(991, 788);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Brands";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // brandControl1
            // 
            this.brandControl1.BackColor = System.Drawing.Color.White;
            this.brandControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandControl1.Location = new System.Drawing.Point(4, 4);
            this.brandControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brandControl1.Name = "brandControl1";
            this.brandControl1.Size = new System.Drawing.Size(983, 780);
            this.brandControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.categoryControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(991, 788);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Category";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // categoryControl1
            // 
            this.categoryControl1.BackColor = System.Drawing.Color.White;
            this.categoryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryControl1.Location = new System.Drawing.Point(4, 4);
            this.categoryControl1.Name = "categoryControl1";
            this.categoryControl1.Size = new System.Drawing.Size(983, 780);
            this.categoryControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.stockManager1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(991, 788);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Current Stock";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // stockManager1
            // 
            this.stockManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockManager1.Location = new System.Drawing.Point(4, 4);
            this.stockManager1.Margin = new System.Windows.Forms.Padding(5);
            this.stockManager1.Name = "stockManager1";
            this.stockManager1.Size = new System.Drawing.Size(983, 780);
            this.stockManager1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.returnManager1);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(991, 788);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Returned";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // returnManager1
            // 
            this.returnManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnManager1.Location = new System.Drawing.Point(4, 4);
            this.returnManager1.Margin = new System.Windows.Forms.Padding(5);
            this.returnManager1.Name = "returnManager1";
            this.returnManager1.Size = new System.Drawing.Size(983, 780);
            this.returnManager1.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.searchContent1);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(991, 788);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Search";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // searchContent1
            // 
            this.searchContent1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchContent1.AutoSize = true;
            this.searchContent1.Location = new System.Drawing.Point(0, 1);
            this.searchContent1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.searchContent1.Name = "searchContent1";
            this.searchContent1.Size = new System.Drawing.Size(1321, 1560);
            this.searchContent1.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.purchaseLogContent1);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage8.Size = new System.Drawing.Size(991, 788);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Purchase Logs";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // purchaseLogContent1
            // 
            this.purchaseLogContent1.Location = new System.Drawing.Point(0, 0);
            this.purchaseLogContent1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchaseLogContent1.Name = "purchaseLogContent1";
            this.purchaseLogContent1.Size = new System.Drawing.Size(1115, 990);
            this.purchaseLogContent1.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage9.Size = new System.Drawing.Size(991, 788);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Logistics";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.locationManager1);
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage10.Size = new System.Drawing.Size(991, 788);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Location";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // locationManager1
            // 
            this.locationManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationManager1.Location = new System.Drawing.Point(4, 4);
            this.locationManager1.Margin = new System.Windows.Forms.Padding(5);
            this.locationManager1.Name = "locationManager1";
            this.locationManager1.Size = new System.Drawing.Size(983, 780);
            this.locationManager1.TabIndex = 0;
            // 
            // productsControl1
            // 
            this.productsControl1.BackColor = System.Drawing.Color.White;
            this.productsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsControl1.Location = new System.Drawing.Point(4, 4);
            this.productsControl1.Name = "productsControl1";
            this.productsControl1.Size = new System.Drawing.Size(983, 780);
            this.productsControl1.TabIndex = 0;
            // 
            // MainInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 817);
            this.Controls.Add(this.optionTabs);
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainInventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.optionTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.TabControl optionTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private Features.SearchTab.SearchContent searchContent1;
        private Features.Dashboard.Dashboard dashboard1;
        private Features.menuPanel.menuPanelButton plOption;
        private Features.menuPanel.menuPanelButton searchOption;
        private Features.menuPanel.menuPanelButton returnedOption;
        private Features.menuPanel.menuPanelButton stockOption;
        private Features.menuPanel.menuPanelButton categoryOption;
        private Features.menuPanel.menuPanelButton brandOption;
        private Features.menuPanel.menuPanelButton productOption;
        private Features.menuPanel.menuPanelButton dashboardOption;
        private System.Windows.Forms.TabPage tabPage10;
        private Features.menuPanel.menuPanelButton locationOption;
        private Features.Stock.StockManager stockManager1;
        private Features.Return.ReturnManager returnManager1;
        private Features.Location.LocationManager locationManager1;
        private Features.BrandTab.BrandControl brandControl1;
        private Features.PurchaseLogTab.PurchaseLogContent purchaseLogContent1;
        private Features.CategoryTab.CategoryControl categoryControl1;
        private Features.ProductTab.ProductsControl productsControl1;
    }
}

