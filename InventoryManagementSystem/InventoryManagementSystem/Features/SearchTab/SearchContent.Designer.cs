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
            this.AddFilter = new System.Windows.Forms.Button();
            this.FilterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ResultView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFilter
            // 
            this.AddFilter.Location = new System.Drawing.Point(4, 46);
            this.AddFilter.Name = "AddFilter";
            this.AddFilter.Size = new System.Drawing.Size(197, 92);
            this.AddFilter.TabIndex = 0;
            this.AddFilter.Text = "Add FIlter";
            this.AddFilter.UseVisualStyleBackColor = true;
            this.AddFilter.Click += new System.EventHandler(this.AddFilter_Click);
            // 
            // FilterPanel
            // 
            this.FilterPanel.Location = new System.Drawing.Point(207, 46);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(905, 198);
            this.FilterPanel.TabIndex = 1;
            // 
            // ResultView
            // 
            this.ResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultView.Location = new System.Drawing.Point(4, 464);
            this.ResultView.Name = "ResultView";
            this.ResultView.RowTemplate.Height = 28;
            this.ResultView.Size = new System.Drawing.Size(1108, 346);
            this.ResultView.TabIndex = 2;
            // 
            // SearchContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultView);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.AddFilter);
            this.Name = "SearchContent";
            this.Size = new System.Drawing.Size(1115, 990);
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddFilter;
        private System.Windows.Forms.FlowLayoutPanel FilterPanel;
        private System.Windows.Forms.DataGridView ResultView;
    }
}
