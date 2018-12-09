namespace InventoryManagementSystem.Features.BrandTab
{
    partial class UpdateBrandForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.brandTxt = new System.Windows.Forms.TextBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdateBrand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.brandTxt);
            this.groupBox1.Controls.Add(this.brandComboBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.UpdateBrand);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Brand";
            // 
            // brandTxt
            // 
            this.brandTxt.BackColor = System.Drawing.SystemColors.Info;
            this.brandTxt.Location = new System.Drawing.Point(157, 113);
            this.brandTxt.Name = "brandTxt";
            this.brandTxt.ReadOnly = true;
            this.brandTxt.Size = new System.Drawing.Size(42, 31);
            this.brandTxt.TabIndex = 15;
            // 
            // brandComboBox
            // 
            this.brandComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(205, 113);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(365, 33);
            this.brandComboBox.TabIndex = 14;
            this.brandComboBox.SelectedIndexChanged += new System.EventHandler(this.brandComboBox_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.update;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(596, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 90);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateBrand
            // 
            this.UpdateBrand.BackColor = System.Drawing.Color.SteelBlue;
            this.UpdateBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBrand.ForeColor = System.Drawing.Color.White;
            this.UpdateBrand.Location = new System.Drawing.Point(252, 186);
            this.UpdateBrand.Name = "UpdateBrand";
            this.UpdateBrand.Size = new System.Drawing.Size(282, 46);
            this.UpdateBrand.TabIndex = 12;
            this.UpdateBrand.Text = "Update brand";
            this.UpdateBrand.UseVisualStyleBackColor = false;
            this.UpdateBrand.Click += new System.EventHandler(this.UpdateBrand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Brand name:";
            // 
            // UpdateBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 319);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateBrandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateBrandForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox brandTxt;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UpdateBrand;
        private System.Windows.Forms.Label label1;
    }
}