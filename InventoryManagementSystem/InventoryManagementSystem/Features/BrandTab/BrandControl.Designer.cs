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
            this.ViewBrand = new System.Windows.Forms.Button();
            this.GroupData = new System.Windows.Forms.GroupBox();
            this.ViewDataList = new System.Windows.Forms.DataGridView();
            this.UpdateBrand = new System.Windows.Forms.Button();
            this.InsertBrand = new System.Windows.Forms.Button();
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
            this.pictureBox1.Size = new System.Drawing.Size(106, 101);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // NameWindow
            // 
            this.NameWindow.AutoSize = true;
            this.NameWindow.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameWindow.ForeColor = System.Drawing.Color.SteelBlue;
            this.NameWindow.Location = new System.Drawing.Point(9, 1);
            this.NameWindow.Name = "NameWindow";
            this.NameWindow.Size = new System.Drawing.Size(107, 40);
            this.NameWindow.TabIndex = 16;
            this.NameWindow.Text = "Brand";
            // 
            // ViewBrand
            // 
            this.ViewBrand.BackColor = System.Drawing.Color.SteelBlue;
            this.ViewBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewBrand.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBrand.ForeColor = System.Drawing.Color.White;
            this.ViewBrand.Location = new System.Drawing.Point(520, 130);
            this.ViewBrand.Name = "ViewBrand";
            this.ViewBrand.Size = new System.Drawing.Size(104, 37);
            this.ViewBrand.TabIndex = 15;
            this.ViewBrand.Text = "View";
            this.ViewBrand.UseVisualStyleBackColor = false;
            this.ViewBrand.Click += new System.EventHandler(this.ViewBrand_Click_1);
            // 
            // GroupData
            // 
            this.GroupData.Controls.Add(this.ViewDataList);
            this.GroupData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupData.Location = new System.Drawing.Point(3, 203);
            this.GroupData.Name = "GroupData";
            this.GroupData.Size = new System.Drawing.Size(847, 538);
            this.GroupData.TabIndex = 14;
            this.GroupData.TabStop = false;
            this.GroupData.Text = "Inventory";
            // 
            // ViewDataList
            // 
            this.ViewDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDataList.Location = new System.Drawing.Point(6, 29);
            this.ViewDataList.Name = "ViewDataList";
            this.ViewDataList.RowTemplate.Height = 24;
            this.ViewDataList.Size = new System.Drawing.Size(835, 503);
            this.ViewDataList.TabIndex = 0;
            // 
            // UpdateBrand
            // 
            this.UpdateBrand.BackColor = System.Drawing.Color.SteelBlue;
            this.UpdateBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBrand.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBrand.ForeColor = System.Drawing.Color.White;
            this.UpdateBrand.Location = new System.Drawing.Point(740, 130);
            this.UpdateBrand.Name = "UpdateBrand";
            this.UpdateBrand.Size = new System.Drawing.Size(104, 37);
            this.UpdateBrand.TabIndex = 12;
            this.UpdateBrand.Text = "Update";
            this.UpdateBrand.UseVisualStyleBackColor = false;
            this.UpdateBrand.Click += new System.EventHandler(this.UpdateBrand_Click_1);
            // 
            // InsertBrand
            // 
            this.InsertBrand.BackColor = System.Drawing.Color.SteelBlue;
            this.InsertBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertBrand.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBrand.ForeColor = System.Drawing.Color.White;
            this.InsertBrand.Location = new System.Drawing.Point(630, 130);
            this.InsertBrand.Name = "InsertBrand";
            this.InsertBrand.Size = new System.Drawing.Size(104, 37);
            this.InsertBrand.TabIndex = 13;
            this.InsertBrand.Text = "Insert";
            this.InsertBrand.UseVisualStyleBackColor = false;
            this.InsertBrand.Click += new System.EventHandler(this.InsertBrand_Click_1);
            // 
            // BrandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameWindow);
            this.Controls.Add(this.ViewBrand);
            this.Controls.Add(this.GroupData);
            this.Controls.Add(this.UpdateBrand);
            this.Controls.Add(this.InsertBrand);
            this.Name = "BrandControl";
            this.Size = new System.Drawing.Size(853, 743);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameWindow;
        private System.Windows.Forms.Button ViewBrand;
        private System.Windows.Forms.GroupBox GroupData;
        private System.Windows.Forms.DataGridView ViewDataList;
        private System.Windows.Forms.Button UpdateBrand;
        private System.Windows.Forms.Button InsertBrand;
    }
}
