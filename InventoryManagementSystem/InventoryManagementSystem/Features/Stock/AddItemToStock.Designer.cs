namespace InventoryManagementSystem.Features.Stock
{
    partial class AddItemToStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.productLocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productBarcode = new System.Windows.Forms.TextBox();
            this.productList = new System.Windows.Forms.ComboBox();
            this.productQantity = new System.Windows.Forms.NumericUpDown();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productQantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product:";
            // 
            // productLocation
            // 
            this.productLocation.FormattingEnabled = true;
            this.productLocation.Items.AddRange(new object[] {
            "4"});
            this.productLocation.Location = new System.Drawing.Point(129, 121);
            this.productLocation.Name = "productLocation";
            this.productLocation.Size = new System.Drawing.Size(160, 21);
            this.productLocation.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location:";
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Location = new System.Drawing.Point(47, 287);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(149, 23);
            this.Ok.TabIndex = 14;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(213, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Barcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantity:";
            // 
            // productBarcode
            // 
            this.productBarcode.Location = new System.Drawing.Point(129, 82);
            this.productBarcode.Name = "productBarcode";
            this.productBarcode.ReadOnly = true;
            this.productBarcode.Size = new System.Drawing.Size(160, 20);
            this.productBarcode.TabIndex = 20;
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.productList.Location = new System.Drawing.Point(129, 44);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(160, 21);
            this.productList.TabIndex = 22;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // productQantity
            // 
            this.productQantity.Location = new System.Drawing.Point(147, 163);
            this.productQantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.productQantity.Name = "productQantity";
            this.productQantity.Size = new System.Drawing.Size(108, 20);
            this.productQantity.TabIndex = 26;
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(129, 244);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Date of purchase:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total Cost:";
            // 
            // totalCost
            // 
            this.totalCost.Location = new System.Drawing.Point(147, 202);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(100, 20);
            this.totalCost.TabIndex = 31;
            // 
            // AddItemToStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 332);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date);
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
            this.Name = "AddItemToStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItemToStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productQantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productBarcode;
        private System.Windows.Forms.ComboBox productList;
        private System.Windows.Forms.NumericUpDown productQantity;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalCost;
    }
}