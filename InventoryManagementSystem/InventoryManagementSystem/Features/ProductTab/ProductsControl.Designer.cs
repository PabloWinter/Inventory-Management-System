namespace InventoryManagementSystem.Features.ProductTab
{
    partial class ProductsControl
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
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.GroupData = new System.Windows.Forms.GroupBox();
            this.ViewDataList = new System.Windows.Forms.DataGridView();
            this.NameWindow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.GroupData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.SteelBlue;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Insert.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.Color.White;
            this.Insert.Location = new System.Drawing.Point(641, 109);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(240, 57);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.SteelBlue;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(897, 109);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(240, 57);
            this.Update.TabIndex = 0;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // GroupData
            // 
            this.GroupData.Controls.Add(this.ViewDataList);
            this.GroupData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupData.Location = new System.Drawing.Point(3, 202);
            this.GroupData.Name = "GroupData";
            this.GroupData.Size = new System.Drawing.Size(1134, 705);
            this.GroupData.TabIndex = 2;
            this.GroupData.TabStop = false;
            this.GroupData.Text = "Inventory";
            // 
            // ViewDataList
            // 
            this.ViewDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDataList.Location = new System.Drawing.Point(6, 29);
            this.ViewDataList.Name = "ViewDataList";
            this.ViewDataList.RowTemplate.Height = 24;
            this.ViewDataList.Size = new System.Drawing.Size(1122, 683);
            this.ViewDataList.TabIndex = 0;
            // 
            // NameWindow
            // 
            this.NameWindow.AutoSize = true;
            this.NameWindow.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameWindow.ForeColor = System.Drawing.Color.SteelBlue;
            this.NameWindow.Location = new System.Drawing.Point(9, 0);
            this.NameWindow.Name = "NameWindow";
            this.NameWindow.Size = new System.Drawing.Size(193, 50);
            this.NameWindow.TabIndex = 4;
            this.NameWindow.Text = "Products";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.report;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 119);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshbtn.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.Color.White;
            this.refreshbtn.Location = new System.Drawing.Point(383, 109);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(240, 57);
            this.refreshbtn.TabIndex = 25;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameWindow);
            this.Controls.Add(this.GroupData);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Name = "ProductsControl";
            this.Size = new System.Drawing.Size(1140, 910);
            this.GroupData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.GroupBox GroupData;
        private System.Windows.Forms.DataGridView ViewDataList;
        private System.Windows.Forms.Label NameWindow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button refreshbtn;
    }
}
