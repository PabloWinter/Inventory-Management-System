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
            this.SuspendLayout();
            // 
            // TableBox
            // 
            this.TableBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TableBox.FormattingEnabled = true;
            this.TableBox.Location = new System.Drawing.Point(3, 3);
            this.TableBox.Name = "TableBox";
            this.TableBox.Size = new System.Drawing.Size(237, 33);
            this.TableBox.TabIndex = 0;
            this.TableBox.SelectedIndexChanged += new System.EventHandler(this.TableBox_SelectedIndexChanged);
            // 
            // ColumnBox
            // 
            this.ColumnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ColumnBox.FormattingEnabled = true;
            this.ColumnBox.Location = new System.Drawing.Point(246, 3);
            this.ColumnBox.Name = "ColumnBox";
            this.ColumnBox.Size = new System.Drawing.Size(322, 33);
            this.ColumnBox.TabIndex = 1;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColumnBox);
            this.Controls.Add(this.TableBox);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(900, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TableBox;
        private System.Windows.Forms.ComboBox ColumnBox;
    }
}
