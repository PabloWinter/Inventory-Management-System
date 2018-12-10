﻿namespace InventoryManagementSystem.Features.CategoryTab
{
    partial class CategoryControl
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
            this.NameWindow = new System.Windows.Forms.Label();
            this.ViewCategory = new System.Windows.Forms.Button();
            this.GroupData = new System.Windows.Forms.GroupBox();
            this.ViewDataList = new System.Windows.Forms.DataGridView();
            this.UpdateCategory = new System.Windows.Forms.Button();
            this.InsertCategory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameWindow
            // 
            this.NameWindow.AutoSize = true;
            this.NameWindow.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameWindow.ForeColor = System.Drawing.Color.SteelBlue;
            this.NameWindow.Location = new System.Drawing.Point(9, 1);
            this.NameWindow.Name = "NameWindow";
            this.NameWindow.Size = new System.Drawing.Size(153, 40);
            this.NameWindow.TabIndex = 22;
            this.NameWindow.Text = "Category";
            // 
            // ViewCategory
            // 
            this.ViewCategory.BackColor = System.Drawing.Color.SteelBlue;
            this.ViewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewCategory.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCategory.ForeColor = System.Drawing.Color.White;
            this.ViewCategory.Location = new System.Drawing.Point(520, 130);
            this.ViewCategory.Name = "ViewCategory";
            this.ViewCategory.Size = new System.Drawing.Size(104, 37);
            this.ViewCategory.TabIndex = 21;
            this.ViewCategory.Text = "View";
            this.ViewCategory.UseVisualStyleBackColor = false;
            this.ViewCategory.Click += new System.EventHandler(this.ViewCategory_Click);
            // 
            // GroupData
            // 
            this.GroupData.Controls.Add(this.ViewDataList);
            this.GroupData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupData.Location = new System.Drawing.Point(3, 203);
            this.GroupData.Name = "GroupData";
            this.GroupData.Size = new System.Drawing.Size(847, 538);
            this.GroupData.TabIndex = 20;
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
            // UpdateCategory
            // 
            this.UpdateCategory.BackColor = System.Drawing.Color.SteelBlue;
            this.UpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateCategory.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCategory.ForeColor = System.Drawing.Color.White;
            this.UpdateCategory.Location = new System.Drawing.Point(740, 130);
            this.UpdateCategory.Name = "UpdateCategory";
            this.UpdateCategory.Size = new System.Drawing.Size(104, 37);
            this.UpdateCategory.TabIndex = 18;
            this.UpdateCategory.Text = "Update";
            this.UpdateCategory.UseVisualStyleBackColor = false;
            this.UpdateCategory.Click += new System.EventHandler(this.UpdateCategory_Click);
            // 
            // InsertCategory
            // 
            this.InsertCategory.BackColor = System.Drawing.Color.SteelBlue;
            this.InsertCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertCategory.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertCategory.ForeColor = System.Drawing.Color.White;
            this.InsertCategory.Location = new System.Drawing.Point(630, 130);
            this.InsertCategory.Name = "InsertCategory";
            this.InsertCategory.Size = new System.Drawing.Size(104, 37);
            this.InsertCategory.TabIndex = 19;
            this.InsertCategory.Text = "Insert";
            this.InsertCategory.UseVisualStyleBackColor = false;
            this.InsertCategory.Click += new System.EventHandler(this.InsertCategory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.list;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 101);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NameWindow);
            this.Controls.Add(this.ViewCategory);
            this.Controls.Add(this.GroupData);
            this.Controls.Add(this.UpdateCategory);
            this.Controls.Add(this.InsertCategory);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(853, 743);
            this.GroupData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameWindow;
        private System.Windows.Forms.Button ViewCategory;
        private System.Windows.Forms.GroupBox GroupData;
        private System.Windows.Forms.DataGridView ViewDataList;
        private System.Windows.Forms.Button UpdateCategory;
        private System.Windows.Forms.Button InsertCategory;
    }
}
