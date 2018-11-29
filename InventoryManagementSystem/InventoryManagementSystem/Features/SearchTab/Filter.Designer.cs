namespace InventoryManagementSystem.Features.SearchTab
{
    partial class Filter
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
            this.TableBox = new System.Windows.Forms.ComboBox();
            this.ColumnBox = new System.Windows.Forms.ComboBox();
            this.OperatorBox = new System.Windows.Forms.ComboBox();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TableBox
            // 
            this.TableBox.FormattingEnabled = true;
            this.TableBox.Location = new System.Drawing.Point(3, 3);
            this.TableBox.Name = "TableBox";
            this.TableBox.Size = new System.Drawing.Size(212, 28);
            this.TableBox.TabIndex = 0;
            // 
            // ColumnBox
            // 
            this.ColumnBox.FormattingEnabled = true;
            this.ColumnBox.Location = new System.Drawing.Point(221, 3);
            this.ColumnBox.Name = "ColumnBox";
            this.ColumnBox.Size = new System.Drawing.Size(212, 28);
            this.ColumnBox.TabIndex = 1;
            // 
            // OperatorBox
            // 
            this.OperatorBox.FormattingEnabled = true;
            this.OperatorBox.Location = new System.Drawing.Point(439, 3);
            this.OperatorBox.Name = "OperatorBox";
            this.OperatorBox.Size = new System.Drawing.Size(212, 28);
            this.OperatorBox.TabIndex = 2;
            // 
            // ValueBox
            // 
            this.ValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueBox.Location = new System.Drawing.Point(657, 3);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(254, 28);
            this.ValueBox.TabIndex = 3;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.OperatorBox);
            this.Controls.Add(this.ColumnBox);
            this.Controls.Add(this.TableBox);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(915, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TableBox;
        private System.Windows.Forms.ComboBox ColumnBox;
        private System.Windows.Forms.ComboBox OperatorBox;
        private System.Windows.Forms.TextBox ValueBox;
    }
}
