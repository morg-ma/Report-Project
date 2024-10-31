namespace WindowsPL
{
    partial class ShowInfo
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
            totalLabel = new Label();
            InfoDataTable = new DataGridView();
            empLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)InfoDataTable).BeginInit();
            SuspendLayout();
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.Location = new Point(24, 23);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(412, 28);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "The total number of the Employees:";
            // 
            // InfoDataTable
            // 
            InfoDataTable.AllowUserToAddRows = false;
            InfoDataTable.AllowUserToDeleteRows = false;
            InfoDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InfoDataTable.Location = new Point(12, 163);
            InfoDataTable.Name = "InfoDataTable";
            InfoDataTable.ReadOnly = true;
            InfoDataTable.RowHeadersWidth = 51;
            InfoDataTable.RowTemplate.Height = 29;
            InfoDataTable.Size = new Size(776, 275);
            InfoDataTable.TabIndex = 1;
            // 
            // empLabel
            // 
            empLabel.AutoSize = true;
            empLabel.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            empLabel.Location = new Point(12, 132);
            empLabel.Name = "empLabel";
            empLabel.Size = new Size(194, 28);
            empLabel.TabIndex = 2;
            empLabel.Text = "The Employees:";
            // 
            // ShowInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(empLabel);
            Controls.Add(InfoDataTable);
            Controls.Add(totalLabel);
            Name = "ShowInfo";
            Text = "ShowInfo";
            ((System.ComponentModel.ISupportInitialize)InfoDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalLabel;
        private DataGridView InfoDataTable;
        private Label empLabel;
    }
}