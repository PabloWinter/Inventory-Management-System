namespace InventoryManagementSystem.Features.Return
{
    partial class EditItemInReturn
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
            this.productLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.productQantity = new System.Windows.Forms.NumericUpDown();
            this.productList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productBarcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productQantity)).BeginInit();
            this.SuspendLayout();
            // 
            // productLocation
            // 
            this.productLocation.Location = new System.Drawing.Point(120, 111);
            this.productLocation.Name = "productLocation";
            this.productLocation.ReadOnly = true;
            this.productLocation.Size = new System.Drawing.Size(160, 20);
            this.productLocation.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(250, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // productQantity
            // 
            this.productQantity.Location = new System.Drawing.Point(139, 153);
            this.productQantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.productQantity.Name = "productQantity";
            this.productQantity.Size = new System.Drawing.Size(108, 20);
            this.productQantity.TabIndex = 47;
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.productList.Location = new System.Drawing.Point(121, 34);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(160, 21);
            this.productList.TabIndex = 46;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Quantity:";
            // 
            // productBarcode
            // 
            this.productBarcode.Location = new System.Drawing.Point(121, 72);
            this.productBarcode.Name = "productBarcode";
            this.productBarcode.ReadOnly = true;
            this.productBarcode.Size = new System.Drawing.Size(160, 20);
            this.productBarcode.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Barcode:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(144, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Location = new System.Drawing.Point(33, 222);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(83, 23);
            this.Ok.TabIndex = 41;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Product to Edit:";
            // 
            // EditItemInReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 296);
            this.Controls.Add(this.productLocation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productQantity);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productBarcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditItemInReturn";
            this.Text = "Edit Return Item";
            this.Load += new System.EventHandler(this.EditItemInReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productQantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown productQantity;
        private System.Windows.Forms.ComboBox productList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productBarcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}