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
            this.Print = new System.Windows.Forms.Button();
            this.GroupData = new System.Windows.Forms.GroupBox();
            this.ViewDataList = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.Button();
            this.NameWindow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.SteelBlue;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Insert.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.Color.White;
            this.Insert.Location = new System.Drawing.Point(520, 129);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(104, 37);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.SteelBlue;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(630, 129);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(104, 37);
            this.Update.TabIndex = 0;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.SteelBlue;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Print.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.ForeColor = System.Drawing.Color.White;
            this.Print.Location = new System.Drawing.Point(740, 129);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(104, 37);
            this.Print.TabIndex = 1;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            // 
            // GroupData
            // 
            this.GroupData.Controls.Add(this.ViewDataList);
            this.GroupData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupData.Location = new System.Drawing.Point(3, 202);
            this.GroupData.Name = "GroupData";
            this.GroupData.Size = new System.Drawing.Size(847, 538);
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
            this.ViewDataList.Size = new System.Drawing.Size(835, 503);
            this.ViewDataList.TabIndex = 0;
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.SteelBlue;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.View.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ForeColor = System.Drawing.Color.White;
            this.View.Location = new System.Drawing.Point(410, 129);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(104, 37);
            this.View.TabIndex = 3;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // NameWindow
            // 
            this.NameWindow.AutoSize = true;
            this.NameWindow.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameWindow.ForeColor = System.Drawing.Color.SteelBlue;
            this.NameWindow.Location = new System.Drawing.Point(9, 0);
            this.NameWindow.Name = "NameWindow";
            this.NameWindow.Size = new System.Drawing.Size(108, 40);
            this.NameWindow.TabIndex = 4;
            this.NameWindow.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.report;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 101);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameWindow);
            this.Controls.Add(this.View);
            this.Controls.Add(this.GroupData);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Name = "ProductsControl";
            this.Size = new System.Drawing.Size(853, 743);
            this.GroupData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.GroupBox GroupData;
        private System.Windows.Forms.DataGridView ViewDataList;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Label NameWindow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
