namespace InventoryManagementSystem.Features.SearchTab
{
    partial class ExtraFilter
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
            this.ExValueBox = new System.Windows.Forms.TextBox();
            this.ExOpBox = new System.Windows.Forms.ComboBox();
            this.ExColumnBox = new System.Windows.Forms.ComboBox();
            this.ExLogicalBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ExValueBox
            // 
            this.ExValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ExValueBox.Location = new System.Drawing.Point(650, 3);
            this.ExValueBox.Name = "ExValueBox";
            this.ExValueBox.Size = new System.Drawing.Size(246, 32);
            this.ExValueBox.TabIndex = 7;
            // 
            // ExOpBox
            // 
            this.ExOpBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExOpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExOpBox.FormattingEnabled = true;
            this.ExOpBox.Location = new System.Drawing.Point(574, 3);
            this.ExOpBox.Name = "ExOpBox";
            this.ExOpBox.Size = new System.Drawing.Size(70, 33);
            this.ExOpBox.TabIndex = 6;
            // 
            // ExColumnBox
            // 
            this.ExColumnBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExColumnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExColumnBox.FormattingEnabled = true;
            this.ExColumnBox.Location = new System.Drawing.Point(246, 3);
            this.ExColumnBox.Name = "ExColumnBox";
            this.ExColumnBox.Size = new System.Drawing.Size(322, 33);
            this.ExColumnBox.TabIndex = 5;
            this.ExColumnBox.SelectedIndexChanged += new System.EventHandler(this.ExColumnBox_SelectedIndexChanged);
            // 
            // ExLogicalBox
            // 
            this.ExLogicalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExLogicalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExLogicalBox.FormattingEnabled = true;
            this.ExLogicalBox.Location = new System.Drawing.Point(143, 3);
            this.ExLogicalBox.Name = "ExLogicalBox";
            this.ExLogicalBox.Size = new System.Drawing.Size(97, 33);
            this.ExLogicalBox.TabIndex = 4;
            // 
            // ExtraFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExValueBox);
            this.Controls.Add(this.ExOpBox);
            this.Controls.Add(this.ExColumnBox);
            this.Controls.Add(this.ExLogicalBox);
            this.Name = "ExtraFilter";
            this.Size = new System.Drawing.Size(900, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExValueBox;
        private System.Windows.Forms.ComboBox ExOpBox;
        private System.Windows.Forms.ComboBox ExColumnBox;
        private System.Windows.Forms.ComboBox ExLogicalBox;
    }
}
