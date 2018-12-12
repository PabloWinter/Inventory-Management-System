namespace InventoryManagementSystem.Features.BrandTab
{
    partial class BrandControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameWindow = new System.Windows.Forms.Label();
            this.GroupData = new System.Windows.Forms.GroupBox();
            this.ViewDataList = new System.Windows.Forms.DataGridView();
            this.UpdateBrand = new System.Windows.Forms.Button();
            this.InsertBrand = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.branding;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 119);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // NameWindow
            // 
            this.NameWindow.AutoSize = true;
            this.NameWindow.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameWindow.ForeColor = System.Drawing.Color.SteelBlue;
            this.NameWindow.Location = new System.Drawing.Point(9, 1);
            this.NameWindow.Name = "NameWindow";
            this.NameWindow.Size = new System.Drawing.Size(136, 50);
            this.NameWindow.TabIndex = 16;
            this.NameWindow.Text = "Brand";
            // 
            // GroupData
            // 
            this.GroupData.Controls.Add(this.ViewDataList);
            this.GroupData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupData.Location = new System.Drawing.Point(3, 203);
            this.GroupData.Name = "GroupData";
            this.GroupData.Size = new System.Drawing.Size(1134, 704);
            this.GroupData.TabIndex = 14;
            this.GroupData.TabStop = false;
            this.GroupData.Text = "Inventory";
            // 
            // ViewDataList
            // 
            this.ViewDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDataList.Location = new System.Drawing.Point(6, 29);
            this.ViewDataList.Name = "ViewDataList";
            this.ViewDataList.RowTemplate.Height = 24;
            this.ViewDataList.Size = new System.Drawing.Size(1122, 773);
            this.ViewDataList.TabIndex = 0;
            // 
            // UpdateBrand
            // 
            this.UpdateBrand.BackColor = System.Drawing.Color.SteelBlue;
            this.UpdateBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBrand.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBrand.ForeColor = System.Drawing.Color.White;
            this.UpdateBrand.Location = new System.Drawing.Point(897, 110);
            this.UpdateBrand.Name = "UpdateBrand";
            this.UpdateBrand.Size = new System.Drawing.Size(240, 57);
            this.UpdateBrand.TabIndex = 12;
            this.UpdateBrand.Text = "Update";
            this.UpdateBrand.UseVisualStyleBackColor = false;
            this.UpdateBrand.Click += new System.EventHandler(this.UpdateBrand_Click_1);
            // 
            // InsertBrand
            // 
            this.InsertBrand.BackColor = System.Drawing.Color.SteelBlue;
            this.InsertBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertBrand.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBrand.ForeColor = System.Drawing.Color.White;
            this.InsertBrand.Location = new System.Drawing.Point(639, 110);
            this.InsertBrand.Name = "InsertBrand";
            this.InsertBrand.Size = new System.Drawing.Size(240, 57);
            this.InsertBrand.TabIndex = 13;
            this.InsertBrand.Text = "Insert";
            this.InsertBrand.UseVisualStyleBackColor = false;
            this.InsertBrand.Click += new System.EventHandler(this.InsertBrand_Click_1);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshbtn.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.Color.White;
            this.refreshbtn.Location = new System.Drawing.Point(379, 110);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(240, 57);
            this.refreshbtn.TabIndex = 25;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // BrandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameWindow);
            this.Controls.Add(this.GroupData);
            this.Controls.Add(this.UpdateBrand);
            this.Controls.Add(this.InsertBrand);
            this.Name = "BrandControl";
            this.Size = new System.Drawing.Size(1140, 910);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameWindow;
        private System.Windows.Forms.GroupBox GroupData;
        private System.Windows.Forms.DataGridView ViewDataList;
        private System.Windows.Forms.Button UpdateBrand;
        private System.Windows.Forms.Button InsertBrand;
        private System.Windows.Forms.Button refreshbtn;
    }
}
