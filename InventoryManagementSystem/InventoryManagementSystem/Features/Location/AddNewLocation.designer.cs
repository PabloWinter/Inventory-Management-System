namespace InventoryManagementSystem.Features.Location
{
    partial class AddNewLocation
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
            this.locationName = new System.Windows.Forms.TextBox();
            this.locationAddress = new System.Windows.Forms.TextBox();
            this.locationCity = new System.Windows.Forms.TextBox();
            this.locationPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locationName
            // 
            this.locationName.Location = new System.Drawing.Point(91, 30);
            this.locationName.Name = "locationName";
            this.locationName.Size = new System.Drawing.Size(208, 20);
            this.locationName.TabIndex = 0;
            // 
            // locationAddress
            // 
            this.locationAddress.Location = new System.Drawing.Point(91, 75);
            this.locationAddress.Name = "locationAddress";
            this.locationAddress.Size = new System.Drawing.Size(208, 20);
            this.locationAddress.TabIndex = 1;
            // 
            // locationCity
            // 
            this.locationCity.Location = new System.Drawing.Point(91, 120);
            this.locationCity.Name = "locationCity";
            this.locationCity.Size = new System.Drawing.Size(208, 20);
            this.locationCity.TabIndex = 2;
            // 
            // locationPhone
            // 
            this.locationPhone.Location = new System.Drawing.Point(91, 166);
            this.locationPhone.Name = "locationPhone";
            this.locationPhone.Size = new System.Drawing.Size(208, 20);
            this.locationPhone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(109, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Location = new System.Drawing.Point(109, 221);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(149, 23);
            this.Ok.TabIndex = 32;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // AddNewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationPhone);
            this.Controls.Add(this.locationCity);
            this.Controls.Add(this.locationAddress);
            this.Controls.Add(this.locationName);
            this.Name = "AddNewLocation";
            this.Text = "New Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox locationName;
        private System.Windows.Forms.TextBox locationAddress;
        private System.Windows.Forms.TextBox locationCity;
        private System.Windows.Forms.TextBox locationPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Ok;
    }
}