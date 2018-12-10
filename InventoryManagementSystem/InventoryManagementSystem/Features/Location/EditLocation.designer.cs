namespace InventoryManagementSystem.Features.Location
{
    partial class EditLocation
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
            this.button2 = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.locationPhone = new System.Windows.Forms.TextBox();
            this.locationCity = new System.Windows.Forms.TextBox();
            this.locationAddress = new System.Windows.Forms.TextBox();
            this.locationName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newLocartionName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(131, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Location = new System.Drawing.Point(131, 286);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(149, 23);
            this.Ok.TabIndex = 42;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Name:";
            // 
            // locationPhone
            // 
            this.locationPhone.Location = new System.Drawing.Point(113, 231);
            this.locationPhone.Name = "locationPhone";
            this.locationPhone.Size = new System.Drawing.Size(208, 20);
            this.locationPhone.TabIndex = 37;
            // 
            // locationCity
            // 
            this.locationCity.Location = new System.Drawing.Point(113, 185);
            this.locationCity.Name = "locationCity";
            this.locationCity.Size = new System.Drawing.Size(208, 20);
            this.locationCity.TabIndex = 36;
            // 
            // locationAddress
            // 
            this.locationAddress.Location = new System.Drawing.Point(113, 140);
            this.locationAddress.Name = "locationAddress";
            this.locationAddress.Size = new System.Drawing.Size(208, 20);
            this.locationAddress.TabIndex = 35;
            // 
            // locationName
            // 
            this.locationName.FormattingEnabled = true;
            this.locationName.Location = new System.Drawing.Point(116, 59);
            this.locationName.Name = "locationName";
            this.locationName.Size = new System.Drawing.Size(205, 21);
            this.locationName.TabIndex = 44;
            this.locationName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "New Name:";
            // 
            // newLocartionName
            // 
            this.newLocartionName.Location = new System.Drawing.Point(116, 100);
            this.newLocartionName.Name = "newLocartionName";
            this.newLocartionName.Size = new System.Drawing.Size(208, 20);
            this.newLocartionName.TabIndex = 45;
            // 
            // EditLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 359);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newLocartionName);
            this.Controls.Add(this.locationName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationPhone);
            this.Controls.Add(this.locationCity);
            this.Controls.Add(this.locationAddress);
            this.Name = "EditLocation";
            this.Text = "Edit Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox locationPhone;
        private System.Windows.Forms.TextBox locationCity;
        private System.Windows.Forms.TextBox locationAddress;
        private System.Windows.Forms.ComboBox locationName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newLocartionName;
    }
}