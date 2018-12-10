namespace InventoryManagementSystem
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainLoggin = new System.Windows.Forms.GroupBox();
            this.BtnLoggin = new System.Windows.Forms.Button();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.logginImage = new System.Windows.Forms.PictureBox();
            this.ImageStore = new System.Windows.Forms.PictureBox();
            this.ImageCart = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.MainLoggin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logginImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.ImageCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 723);
            this.panel1.TabIndex = 0;
            // 
            // MainLoggin
            // 
            this.MainLoggin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MainLoggin.Controls.Add(this.logginImage);
            this.MainLoggin.Controls.Add(this.BtnLoggin);
            this.MainLoggin.Controls.Add(this.ImageStore);
            this.MainLoggin.Controls.Add(this.passwordlbl);
            this.MainLoggin.Controls.Add(this.emaillbl);
            this.MainLoggin.Controls.Add(this.passwordTxt);
            this.MainLoggin.Controls.Add(this.emailTxt);
            this.MainLoggin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLoggin.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLoggin.Location = new System.Drawing.Point(209, 0);
            this.MainLoggin.Name = "MainLoggin";
            this.MainLoggin.Size = new System.Drawing.Size(961, 723);
            this.MainLoggin.TabIndex = 1;
            this.MainLoggin.TabStop = false;
            this.MainLoggin.Text = "Sign In";
            // 
            // BtnLoggin
            // 
            this.BtnLoggin.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnLoggin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLoggin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLoggin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoggin.ForeColor = System.Drawing.Color.White;
            this.BtnLoggin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLoggin.Location = new System.Drawing.Point(336, 533);
            this.BtnLoggin.Name = "BtnLoggin";
            this.BtnLoggin.Size = new System.Drawing.Size(262, 36);
            this.BtnLoggin.TabIndex = 4;
            this.BtnLoggin.Text = "Submit";
            this.BtnLoggin.UseVisualStyleBackColor = false;
            this.BtnLoggin.Click += new System.EventHandler(this.BtnLoggin_Click);
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(331, 453);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(107, 26);
            this.passwordlbl.TabIndex = 2;
            this.passwordlbl.Text = "Password:";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.ForeColor = System.Drawing.Color.Black;
            this.emaillbl.Location = new System.Drawing.Point(331, 387);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(70, 26);
            this.emaillbl.TabIndex = 1;
            this.emaillbl.Text = "Email:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(336, 482);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(262, 27);
            this.passwordTxt.TabIndex = 0;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(336, 416);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(262, 27);
            this.emailTxt.TabIndex = 0;
            // 
            // logginImage
            // 
            this.logginImage.BackColor = System.Drawing.Color.LightSlateGray;
            this.logginImage.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.safety;
            this.logginImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logginImage.Location = new System.Drawing.Point(556, 539);
            this.logginImage.Name = "logginImage";
            this.logginImage.Size = new System.Drawing.Size(27, 22);
            this.logginImage.TabIndex = 5;
            this.logginImage.TabStop = false;
            // 
            // ImageStore
            // 
            this.ImageStore.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ImageStore.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.factory;
            this.ImageStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageStore.Location = new System.Drawing.Point(336, 105);
            this.ImageStore.Name = "ImageStore";
            this.ImageStore.Size = new System.Drawing.Size(262, 243);
            this.ImageStore.TabIndex = 3;
            this.ImageStore.TabStop = false;
            // 
            // ImageCart
            // 
            this.ImageCart.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.cart;
            this.ImageCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageCart.Location = new System.Drawing.Point(42, 102);
            this.ImageCart.Name = "ImageCart";
            this.ImageCart.Size = new System.Drawing.Size(100, 97);
            this.ImageCart.TabIndex = 0;
            this.ImageCart.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 723);
            this.Controls.Add(this.MainLoggin);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "   Management Inventory";
            this.panel1.ResumeLayout(false);
            this.MainLoggin.ResumeLayout(false);
            this.MainLoggin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logginImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox MainLoggin;
        private System.Windows.Forms.Button BtnLoggin;
        private System.Windows.Forms.PictureBox ImageStore;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.PictureBox logginImage;
        private System.Windows.Forms.PictureBox ImageCart;
    }
}