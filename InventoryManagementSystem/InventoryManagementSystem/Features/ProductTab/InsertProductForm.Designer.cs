namespace InventoryManagementSystem.Features.ProductTab
{
    partial class InsertProductForm
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
            this.InsertProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBrand = new System.Windows.Forms.ComboBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.txtDiscount = new System.Windows.Forms.MaskedTextBox();
            this.txtTax = new System.Windows.Forms.MaskedTextBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.InsertProduct);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBrand);
            this.groupBox1.Controls.Add(this.comboCategory);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.txtTax);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtShortName);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 684);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Product";
            // 
            // InsertProduct
            // 
            this.InsertProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.InsertProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertProduct.ForeColor = System.Drawing.Color.White;
            this.InsertProduct.Location = new System.Drawing.Point(232, 594);
            this.InsertProduct.Name = "InsertProduct";
            this.InsertProduct.Size = new System.Drawing.Size(282, 46);
            this.InsertProduct.TabIndex = 5;
            this.InsertProduct.Text = "Insert product";
            this.InsertProduct.UseVisualStyleBackColor = false;
            this.InsertProduct.Click += new System.EventHandler(this.InsertProduct_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 26);
            this.label9.TabIndex = 4;
            this.label9.Text = "Short product name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Full product name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Brand ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Category ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // comboBrand
            // 
            this.comboBrand.BackColor = System.Drawing.SystemColors.Info;
            this.comboBrand.FormattingEnabled = true;
            this.comboBrand.Items.AddRange(new object[] {
            "ASUS",
            "ACER",
            "HP",
            "APPLE",
            "SAMSUNG",
            "SONY",
            "Lenovo",
            "DELL"});
            this.comboBrand.Location = new System.Drawing.Point(232, 405);
            this.comboBrand.Name = "comboBrand";
            this.comboBrand.Size = new System.Drawing.Size(282, 33);
            this.comboBrand.TabIndex = 3;
            // 
            // comboCategory
            // 
            this.comboCategory.BackColor = System.Drawing.SystemColors.Info;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Electronic Accessories",
            "Desktop",
            "Laptop",
            "Printer",
            "Storage devices"});
            this.comboCategory.Location = new System.Drawing.Point(232, 347);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(282, 33);
            this.comboCategory.TabIndex = 3;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.SystemColors.Info;
            this.txtDiscount.Location = new System.Drawing.Point(232, 236);
            this.txtDiscount.Mask = "00000.00";
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(282, 31);
            this.txtDiscount.TabIndex = 2;
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.Info;
            this.txtTax.Location = new System.Drawing.Point(232, 178);
            this.txtTax.Mask = "00000.00";
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(282, 31);
            this.txtTax.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrice.Location = new System.Drawing.Point(232, 122);
            this.txtPrice.Mask = "00000.00";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(282, 31);
            this.txtPrice.TabIndex = 2;
            // 
            // txtShortName
            // 
            this.txtShortName.BackColor = System.Drawing.SystemColors.Info;
            this.txtShortName.Location = new System.Drawing.Point(232, 523);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(282, 31);
            this.txtShortName.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Info;
            this.txtFullName.Location = new System.Drawing.Point(232, 465);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(282, 31);
            this.txtFullName.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescription.Location = new System.Drawing.Point(232, 292);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(282, 31);
            this.txtDescription.TabIndex = 0;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductName.Location = new System.Drawing.Point(232, 70);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(282, 31);
            this.txtProductName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.design;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(598, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 90);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // InsertProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 685);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "InsertProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                   Insert a new p" +
    "roduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button InsertProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBrand;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.MaskedTextBox txtDiscount;
        private System.Windows.Forms.MaskedTextBox txtTax;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}