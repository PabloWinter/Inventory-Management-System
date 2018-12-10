namespace InventoryManagementSystem.Features.Return
{
    partial class AddItemToReturn
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
            this.productQantity = new System.Windows.Forms.NumericUpDown();
            this.productList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productBarcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.productLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productQantity)).BeginInit();
            this.SuspendLayout();
            // 
            // productQantity
            // 
            this.productQantity.Location = new System.Drawing.Point(155, 169);
            this.productQantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.productQantity.Name = "productQantity";
            this.productQantity.Size = new System.Drawing.Size(108, 20);
            this.productQantity.TabIndex = 36;
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.productList.Location = new System.Drawing.Point(137, 50);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(160, 21);
            this.productList.TabIndex = 35;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Quantity:";
            // 
            // productBarcode
            // 
            this.productBarcode.Location = new System.Drawing.Point(137, 88);
            this.productBarcode.Name = "productBarcode";
            this.productBarcode.ReadOnly = true;
            this.productBarcode.Size = new System.Drawing.Size(160, 20);
            this.productBarcode.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Barcode:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(210, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Location = new System.Drawing.Point(44, 223);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(149, 23);
            this.Ok.TabIndex = 30;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Location:";
            // 
            // productLocation
            // 
            this.productLocation.FormattingEnabled = true;
            this.productLocation.Items.AddRange(new object[] {
            "4"});
            this.productLocation.Location = new System.Drawing.Point(137, 127);
            this.productLocation.Name = "productLocation";
            this.productLocation.Size = new System.Drawing.Size(160, 21);
            this.productLocation.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Product:";
            // 
            // AddItemToReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 310);
            this.Controls.Add(this.productQantity);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productBarcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productLocation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemToReturn";
            this.Text = "AddItemToReturn";
            ((System.ComponentModel.ISupportInitialize)(this.productQantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown productQantity;
        private System.Windows.Forms.ComboBox productList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productBarcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox productLocation;
        private System.Windows.Forms.Label label1;
    }
}