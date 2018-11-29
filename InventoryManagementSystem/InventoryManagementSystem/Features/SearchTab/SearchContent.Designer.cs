namespace InventoryManagementSystem.Features.SearchTab
{
    partial class SearchContent
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
            this.FilterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddFilter = new System.Windows.Forms.Button();
            this.ResultView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterPanel
            // 
            this.FilterPanel.AutoScroll = true;
            this.FilterPanel.Location = new System.Drawing.Point(319, 3);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(793, 203);
            this.FilterPanel.TabIndex = 0;
            // 
            // AddFilter
            // 
            this.AddFilter.Location = new System.Drawing.Point(3, 3);
            this.AddFilter.Name = "AddFilter";
            this.AddFilter.Size = new System.Drawing.Size(131, 59);
            this.AddFilter.TabIndex = 1;
            this.AddFilter.Text = "Add";
            this.AddFilter.UseVisualStyleBackColor = true;
            this.AddFilter.Click += new System.EventHandler(this.AddFilter_Click);
            // 
            // ResultView
            // 
            this.ResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultView.Location = new System.Drawing.Point(3, 506);
            this.ResultView.Name = "ResultView";
            this.ResultView.RowTemplate.Height = 28;
            this.ResultView.Size = new System.Drawing.Size(1109, 378);
            this.ResultView.TabIndex = 2;
            // 
            // SearchContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultView);
            this.Controls.Add(this.AddFilter);
            this.Controls.Add(this.FilterPanel);
            this.Name = "SearchContent";
            this.Size = new System.Drawing.Size(1115, 990);
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FilterPanel;
        private System.Windows.Forms.Button AddFilter;
        private System.Windows.Forms.DataGridView ResultView;
    }
}
