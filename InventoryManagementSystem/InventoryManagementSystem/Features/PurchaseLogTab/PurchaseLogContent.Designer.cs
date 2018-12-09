namespace InventoryManagementSystem.Features.PurchaseLogTab
{
    partial class PurchaseLogContent
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
            this.InitialDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LocationBox = new System.Windows.Forms.ComboBox();
            this.ProductBox = new System.Windows.Forms.ComboBox();
            this.FinalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FilterCost = new System.Windows.Forms.GroupBox();
            this.RunQuery = new System.Windows.Forms.Button();
            this.UntilLabel = new System.Windows.Forms.Label();
            this.StartingDateLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ResultView = new System.Windows.Forms.DataGridView();
            this.ConclusionBox = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.FilterCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).BeginInit();
            this.ConclusionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InitialDatePicker
            // 
            this.InitialDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InitialDatePicker.Location = new System.Drawing.Point(12, 151);
            this.InitialDatePicker.Name = "InitialDatePicker";
            this.InitialDatePicker.Size = new System.Drawing.Size(277, 35);
            this.InitialDatePicker.TabIndex = 6;
            // 
            // LocationBox
            // 
            this.LocationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LocationBox.FormattingEnabled = true;
            this.LocationBox.Location = new System.Drawing.Point(675, 67);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(428, 33);
            this.LocationBox.TabIndex = 5;
            // 
            // ProductBox
            // 
            this.ProductBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProductBox.FormattingEnabled = true;
            this.ProductBox.Location = new System.Drawing.Point(12, 67);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(560, 33);
            this.ProductBox.TabIndex = 4;
            this.ProductBox.SelectedIndexChanged += new System.EventHandler(this.ProductBox_SelectedIndexChanged);
            // 
            // FinalDatePicker
            // 
            this.FinalDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FinalDatePicker.Location = new System.Drawing.Point(295, 151);
            this.FinalDatePicker.Name = "FinalDatePicker";
            this.FinalDatePicker.Size = new System.Drawing.Size(277, 35);
            this.FinalDatePicker.TabIndex = 7;
            // 
            // FilterCost
            // 
            this.FilterCost.Controls.Add(this.RunQuery);
            this.FilterCost.Controls.Add(this.UntilLabel);
            this.FilterCost.Controls.Add(this.StartingDateLabel);
            this.FilterCost.Controls.Add(this.LocationLabel);
            this.FilterCost.Controls.Add(this.ProductLabel);
            this.FilterCost.Controls.Add(this.InitialDatePicker);
            this.FilterCost.Controls.Add(this.LocationBox);
            this.FilterCost.Controls.Add(this.FinalDatePicker);
            this.FilterCost.Controls.Add(this.ProductBox);
            this.FilterCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterCost.Location = new System.Drawing.Point(3, 3);
            this.FilterCost.Name = "FilterCost";
            this.FilterCost.Size = new System.Drawing.Size(1109, 215);
            this.FilterCost.TabIndex = 8;
            this.FilterCost.TabStop = false;
            this.FilterCost.Text = "Unit Cost Search";
            // 
            // RunQuery
            // 
            this.RunQuery.BackColor = System.Drawing.Color.DarkGreen;
            this.RunQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunQuery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RunQuery.Location = new System.Drawing.Point(675, 122);
            this.RunQuery.Name = "RunQuery";
            this.RunQuery.Size = new System.Drawing.Size(218, 64);
            this.RunQuery.TabIndex = 9;
            this.RunQuery.Text = "Run";
            this.RunQuery.UseVisualStyleBackColor = false;
            this.RunQuery.Click += new System.EventHandler(this.RunQuery_Click);
            // 
            // UntilLabel
            // 
            this.UntilLabel.AutoSize = true;
            this.UntilLabel.Location = new System.Drawing.Point(290, 119);
            this.UntilLabel.Name = "UntilLabel";
            this.UntilLabel.Size = new System.Drawing.Size(67, 29);
            this.UntilLabel.TabIndex = 11;
            this.UntilLabel.Text = "Until:";
            // 
            // StartingDateLabel
            // 
            this.StartingDateLabel.AutoSize = true;
            this.StartingDateLabel.Location = new System.Drawing.Point(7, 119);
            this.StartingDateLabel.Name = "StartingDateLabel";
            this.StartingDateLabel.Size = new System.Drawing.Size(76, 29);
            this.StartingDateLabel.TabIndex = 10;
            this.StartingDateLabel.Text = "From:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(670, 35);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(110, 29);
            this.LocationLabel.TabIndex = 9;
            this.LocationLabel.Text = "Location:";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(7, 35);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(102, 29);
            this.ProductLabel.TabIndex = 8;
            this.ProductLabel.Text = "Product:";
            // 
            // ResultView
            // 
            this.ResultView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultView.Location = new System.Drawing.Point(3, 407);
            this.ResultView.Name = "ResultView";
            this.ResultView.RowTemplate.Height = 28;
            this.ResultView.Size = new System.Drawing.Size(1108, 580);
            this.ResultView.TabIndex = 9;
            // 
            // ConclusionBox
            // 
            this.ConclusionBox.Controls.Add(this.ResultLabel);
            this.ConclusionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConclusionBox.Location = new System.Drawing.Point(3, 234);
            this.ConclusionBox.Name = "ConclusionBox";
            this.ConclusionBox.Size = new System.Drawing.Size(1109, 146);
            this.ConclusionBox.TabIndex = 10;
            this.ConclusionBox.TabStop = false;
            this.ConclusionBox.Text = "Unit Cost";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.ResultLabel.Location = new System.Drawing.Point(13, 31);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 29);
            this.ResultLabel.TabIndex = 0;
            // 
            // PurchaseLogContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConclusionBox);
            this.Controls.Add(this.ResultView);
            this.Controls.Add(this.FilterCost);
            this.Name = "PurchaseLogContent";
            this.Size = new System.Drawing.Size(1115, 990);
            this.FilterCost.ResumeLayout(false);
            this.FilterCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).EndInit();
            this.ConclusionBox.ResumeLayout(false);
            this.ConclusionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker InitialDatePicker;
        private System.Windows.Forms.ComboBox LocationBox;
        private System.Windows.Forms.ComboBox ProductBox;
        private System.Windows.Forms.DateTimePicker FinalDatePicker;
        private System.Windows.Forms.GroupBox FilterCost;
        private System.Windows.Forms.Label UntilLabel;
        private System.Windows.Forms.Label StartingDateLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Button RunQuery;
        private System.Windows.Forms.DataGridView ResultView;
        private System.Windows.Forms.GroupBox ConclusionBox;
        private System.Windows.Forms.Label ResultLabel;
    }
}
