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
            this.RunQuery = new System.Windows.Forms.Button();
            this.TableLabel = new System.Windows.Forms.Label();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFilter
            // 
            this.AddFilter.BackColor = System.Drawing.Color.Navy;
            this.AddFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFilter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddFilter.Location = new System.Drawing.Point(4, 46);
            this.AddFilter.Name = "AddFilter";
            this.AddFilter.Size = new System.Drawing.Size(141, 109);
            this.AddFilter.TabIndex = 0;
            this.AddFilter.Text = "Add FIlter";
            this.AddFilter.UseVisualStyleBackColor = false;
            this.AddFilter.Click += new System.EventHandler(this.AddFilter_Click);
            // 
            // FilterPanel
            // 
            this.FilterPanel.AutoScroll = true;
            this.FilterPanel.Location = new System.Drawing.Point(151, 46);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(961, 220);
            this.FilterPanel.TabIndex = 1;
            // 
            // ResultView
            // 
            this.ResultView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultView.Location = new System.Drawing.Point(4, 391);
            this.ResultView.Name = "ResultView";
            this.ResultView.RowTemplate.Height = 28;
            this.ResultView.Size = new System.Drawing.Size(1108, 596);
            this.ResultView.TabIndex = 2;
            // 
            // RunQuery
            // 
            this.RunQuery.BackColor = System.Drawing.Color.DarkGreen;
            this.RunQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunQuery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RunQuery.Location = new System.Drawing.Point(4, 161);
            this.RunQuery.Name = "RunQuery";
            this.RunQuery.Size = new System.Drawing.Size(141, 109);
            this.RunQuery.TabIndex = 3;
            this.RunQuery.Text = "Run";
            this.RunQuery.UseVisualStyleBackColor = false;
            this.RunQuery.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLabel.Location = new System.Drawing.Point(152, 14);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(76, 29);
            this.TableLabel.TabIndex = 4;
            this.TableLabel.Text = "Table";
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnLabel.Location = new System.Drawing.Point(395, 14);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(99, 29);
            this.ColumnLabel.TabIndex = 5;
            this.ColumnLabel.Text = "Filter by";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.Location = new System.Drawing.Point(800, 14);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(74, 29);
            this.ValueLabel.TabIndex = 6;
            this.ValueLabel.Text = "Value";
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Maroon;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RestartButton.Location = new System.Drawing.Point(4, 276);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(141, 109);
            this.RestartButton.TabIndex = 7;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SearchContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.ColumnLabel);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.RunQuery);
            this.Controls.Add(this.ResultView);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.AddFilter);
            this.Name = "SearchContent";
            this.Size = new System.Drawing.Size(1115, 990);
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFilter;
        private System.Windows.Forms.FlowLayoutPanel FilterPanel;
        private System.Windows.Forms.DataGridView ResultView;
        private System.Windows.Forms.Button RunQuery;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Button RestartButton;
    }
}
