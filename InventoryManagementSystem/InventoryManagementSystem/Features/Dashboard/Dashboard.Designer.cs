namespace InventoryManagementSystem.Features.Dashboard
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stockCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outOfStockCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.runningLowCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalStockItemCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.locationCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stockValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "🏠 Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.stockCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 167);
            this.panel1.TabIndex = 1;
            // 
            // stockCount
            // 
            this.stockCount.AutoSize = true;
            this.stockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockCount.Location = new System.Drawing.Point(33, 55);
            this.stockCount.Name = "stockCount";
            this.stockCount.Size = new System.Drawing.Size(431, 73);
            this.stockCount.TabIndex = 1;
            this.stockCount.Text = "Failed to load";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "✔️ In Stock";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.outOfStockCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(24, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 172);
            this.panel2.TabIndex = 2;
            // 
            // outOfStockCount
            // 
            this.outOfStockCount.AutoSize = true;
            this.outOfStockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outOfStockCount.Location = new System.Drawing.Point(33, 55);
            this.outOfStockCount.Name = "outOfStockCount";
            this.outOfStockCount.Size = new System.Drawing.Size(431, 73);
            this.outOfStockCount.TabIndex = 1;
            this.outOfStockCount.Text = "Failed to load";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "⚠️ Out Of Stock";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.runningLowCount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(257, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 167);
            this.panel3.TabIndex = 2;
            // 
            // runningLowCount
            // 
            this.runningLowCount.AutoSize = true;
            this.runningLowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningLowCount.Location = new System.Drawing.Point(33, 55);
            this.runningLowCount.Name = "runningLowCount";
            this.runningLowCount.Size = new System.Drawing.Size(431, 73);
            this.runningLowCount.TabIndex = 1;
            this.runningLowCount.Text = "Failed to load";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "!  Running Low";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(282, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "🔄";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.totalStockItemCount);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(257, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 82);
            this.panel4.TabIndex = 4;
            // 
            // totalStockItemCount
            // 
            this.totalStockItemCount.AutoSize = true;
            this.totalStockItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockItemCount.Location = new System.Drawing.Point(54, 43);
            this.totalStockItemCount.Name = "totalStockItemCount";
            this.totalStockItemCount.Size = new System.Drawing.Size(170, 25);
            this.totalStockItemCount.TabIndex = 1;
            this.totalStockItemCount.Text = "Failed To Load";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "🔢 Stock Item Count";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.stockValue);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(257, 395);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 82);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateBlue;
            this.panel5.Controls.Add(this.locationCount);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(657, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 167);
            this.panel5.TabIndex = 2;
            // 
            // locationCount
            // 
            this.locationCount.AutoSize = true;
            this.locationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationCount.Location = new System.Drawing.Point(33, 55);
            this.locationCount.Name = "locationCount";
            this.locationCount.Size = new System.Drawing.Size(431, 73);
            this.locationCount.TabIndex = 1;
            this.locationCount.Text = "Failed to load";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "🗺️ Locations";
            // 
            // stockValue
            // 
            this.stockValue.AutoSize = true;
            this.stockValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockValue.Location = new System.Drawing.Point(54, 38);
            this.stockValue.Name = "stockValue";
            this.stockValue.Size = new System.Drawing.Size(170, 25);
            this.stockValue.TabIndex = 3;
            this.stockValue.Text = "Failed To Load";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "💵 Stock Value";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1005, 626);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stockCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label outOfStockCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label runningLowCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalStockItemCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label locationCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label stockValue;
        private System.Windows.Forms.Label label8;
    }
}
