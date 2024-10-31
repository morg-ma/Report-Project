namespace WindowsPL
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new Label();
            label2 = new Label();
            nameLabel = new TextBox();
            gender = new GroupBox();
            female = new RadioButton();
            male = new RadioButton();
            status = new Label();
            statusList = new ComboBox();
            skillsBox = new GroupBox();
            java = new CheckBox();
            csharp = new CheckBox();
            computer = new CheckBox();
            cpp = new CheckBox();
            englishLabel = new Label();
            englishPercent = new TextBox();
            label5 = new Label();
            englishPerBar = new ProgressBar();
            arabicPerBar = new ProgressBar();
            label6 = new Label();
            arabicPercent = new TextBox();
            arabicLabel = new Label();
            resultButton = new Button();
            reportGroup = new GroupBox();
            printButton = new Button();
            previewButton = new Button();
            pageSetupButton = new Button();
            reportBox = new ListBox();
            birthDate = new DateTimePicker();
            resetButton = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pageSetupDialog1 = new PageSetupDialog();
            printDialog1 = new PrintDialog();
            AddButton = new Button();
            EmployeeTypeBox = new ComboBox();
            jobTxt = new TextBox();
            label3 = new Label();
            departmentTxt = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            IdList = new ComboBox();
            label11 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            gender.SuspendLayout();
            skillsBox.SuspendLayout();
            reportGroup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 206);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 236);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Birthdate: ";
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(130, 203);
            nameLabel.Margin = new Padding(4, 3, 4, 3);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(213, 27);
            nameLabel.TabIndex = 2;
            // 
            // gender
            // 
            gender.Controls.Add(female);
            gender.Controls.Add(male);
            gender.Location = new Point(52, 382);
            gender.Margin = new Padding(4, 3, 4, 3);
            gender.Name = "gender";
            gender.Padding = new Padding(4, 3, 4, 3);
            gender.Size = new Size(307, 65);
            gender.TabIndex = 3;
            gender.TabStop = false;
            gender.Text = "Gender: ";
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(169, 34);
            female.Margin = new Padding(4, 3, 4, 3);
            female.Name = "female";
            female.Size = new Size(82, 24);
            female.TabIndex = 1;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Checked = true;
            male.Location = new Point(14, 34);
            male.Margin = new Padding(4, 3, 4, 3);
            male.Name = "male";
            male.Size = new Size(66, 24);
            male.TabIndex = 0;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(47, 272);
            status.Margin = new Padding(4, 0, 4, 0);
            status.Name = "status";
            status.Size = new Size(75, 20);
            status.TabIndex = 4;
            status.Text = "Mstatus: ";
            // 
            // statusList
            // 
            statusList.DropDownStyle = ComboBoxStyle.DropDownList;
            statusList.FormattingEnabled = true;
            statusList.Items.AddRange(new object[] { "None", "Married", "Engaged", "Single" });
            statusList.Location = new Point(130, 269);
            statusList.Margin = new Padding(4, 3, 4, 3);
            statusList.Name = "statusList";
            statusList.Size = new Size(213, 28);
            statusList.TabIndex = 19;
            // 
            // skillsBox
            // 
            skillsBox.Controls.Add(java);
            skillsBox.Controls.Add(csharp);
            skillsBox.Controls.Add(computer);
            skillsBox.Controls.Add(cpp);
            skillsBox.Location = new Point(52, 469);
            skillsBox.Margin = new Padding(4, 3, 4, 3);
            skillsBox.Name = "skillsBox";
            skillsBox.Padding = new Padding(4, 3, 4, 3);
            skillsBox.Size = new Size(306, 98);
            skillsBox.TabIndex = 6;
            skillsBox.TabStop = false;
            skillsBox.Text = "Skills";
            // 
            // java
            // 
            java.AutoSize = true;
            java.Location = new Point(22, 61);
            java.Margin = new Padding(4, 3, 4, 3);
            java.Name = "java";
            java.Size = new Size(61, 24);
            java.TabIndex = 3;
            java.Text = "Java";
            java.UseVisualStyleBackColor = true;
            // 
            // csharp
            // 
            csharp.AutoSize = true;
            csharp.Location = new Point(158, 31);
            csharp.Margin = new Padding(4, 3, 4, 3);
            csharp.Name = "csharp";
            csharp.Size = new Size(51, 24);
            csharp.TabIndex = 2;
            csharp.Text = "C#";
            csharp.UseVisualStyleBackColor = true;
            // 
            // computer
            // 
            computer.AutoSize = true;
            computer.Location = new Point(158, 61);
            computer.Margin = new Padding(4, 3, 4, 3);
            computer.Name = "computer";
            computer.Size = new Size(105, 24);
            computer.TabIndex = 1;
            computer.Text = "Computer";
            computer.UseVisualStyleBackColor = true;
            // 
            // cpp
            // 
            cpp.AutoSize = true;
            cpp.Location = new Point(22, 31);
            cpp.Margin = new Padding(4, 3, 4, 3);
            cpp.Name = "cpp";
            cpp.Size = new Size(63, 24);
            cpp.TabIndex = 0;
            cpp.Text = "C++";
            cpp.UseVisualStyleBackColor = true;
            // 
            // englishLabel
            // 
            englishLabel.AutoSize = true;
            englishLabel.Location = new Point(46, 594);
            englishLabel.Margin = new Padding(4, 0, 4, 0);
            englishLabel.Name = "englishLabel";
            englishLabel.Size = new Size(64, 20);
            englishLabel.TabIndex = 7;
            englishLabel.Text = "English:";
            // 
            // englishPercent
            // 
            englishPercent.Location = new Point(119, 591);
            englishPercent.Margin = new Padding(4, 3, 4, 3);
            englishPercent.Name = "englishPercent";
            englishPercent.Size = new Size(56, 27);
            englishPercent.TabIndex = 8;
            englishPercent.TextChanged += englishPercent_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 594);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 9;
            label5.Text = "%";
            // 
            // englishPerBar
            // 
            englishPerBar.Location = new Point(205, 591);
            englishPerBar.Margin = new Padding(4, 3, 4, 3);
            englishPerBar.Name = "englishPerBar";
            englishPerBar.Size = new Size(154, 27);
            englishPerBar.TabIndex = 10;
            englishPerBar.UseWaitCursor = true;
            // 
            // arabicPerBar
            // 
            arabicPerBar.Location = new Point(205, 633);
            arabicPerBar.Margin = new Padding(4, 3, 4, 3);
            arabicPerBar.Name = "arabicPerBar";
            arabicPerBar.Size = new Size(154, 27);
            arabicPerBar.TabIndex = 14;
            arabicPerBar.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 636);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 13;
            label6.Text = "%";
            // 
            // arabicPercent
            // 
            arabicPercent.Location = new Point(119, 633);
            arabicPercent.Margin = new Padding(4, 3, 4, 3);
            arabicPercent.Name = "arabicPercent";
            arabicPercent.Size = new Size(56, 27);
            arabicPercent.TabIndex = 12;
            arabicPercent.TextChanged += arabicPercent_TextChanged;
            // 
            // arabicLabel
            // 
            arabicLabel.AutoSize = true;
            arabicLabel.Location = new Point(46, 636);
            arabicLabel.Margin = new Padding(4, 0, 4, 0);
            arabicLabel.Name = "arabicLabel";
            arabicLabel.Size = new Size(60, 20);
            arabicLabel.TabIndex = 11;
            arabicLabel.Text = "Arabic:";
            // 
            // resultButton
            // 
            resultButton.BackColor = Color.PaleTurquoise;
            resultButton.FlatAppearance.BorderColor = Color.Black;
            resultButton.ForeColor = SystemColors.ActiveCaptionText;
            resultButton.Location = new Point(154, 695);
            resultButton.Margin = new Padding(4, 3, 4, 3);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(161, 54);
            resultButton.TabIndex = 15;
            resultButton.Text = "Show Results";
            resultButton.UseVisualStyleBackColor = false;
            resultButton.Click += resultButton_Click;
            // 
            // reportGroup
            // 
            reportGroup.BackColor = Color.Transparent;
            reportGroup.Controls.Add(printButton);
            reportGroup.Controls.Add(previewButton);
            reportGroup.Controls.Add(pageSetupButton);
            reportGroup.Controls.Add(reportBox);
            reportGroup.Location = new Point(428, 122);
            reportGroup.Margin = new Padding(4, 3, 4, 3);
            reportGroup.Name = "reportGroup";
            reportGroup.Padding = new Padding(4, 3, 4, 3);
            reportGroup.Size = new Size(472, 487);
            reportGroup.TabIndex = 16;
            reportGroup.TabStop = false;
            reportGroup.Text = "Report";
            // 
            // printButton
            // 
            printButton.BackColor = SystemColors.Control;
            printButton.Location = new Point(357, 450);
            printButton.Margin = new Padding(4, 3, 4, 3);
            printButton.Name = "printButton";
            printButton.Size = new Size(106, 29);
            printButton.TabIndex = 20;
            printButton.Text = "Print";
            printButton.UseVisualStyleBackColor = false;
            printButton.Click += printButton_Click;
            // 
            // previewButton
            // 
            previewButton.BackColor = SystemColors.Control;
            previewButton.Location = new Point(186, 450);
            previewButton.Margin = new Padding(4, 3, 4, 3);
            previewButton.Name = "previewButton";
            previewButton.Size = new Size(106, 29);
            previewButton.TabIndex = 19;
            previewButton.Text = "Preview";
            previewButton.UseVisualStyleBackColor = false;
            previewButton.Click += previewButton_Click;
            // 
            // pageSetupButton
            // 
            pageSetupButton.BackColor = SystemColors.Control;
            pageSetupButton.Location = new Point(7, 450);
            pageSetupButton.Margin = new Padding(4, 3, 4, 3);
            pageSetupButton.Name = "pageSetupButton";
            pageSetupButton.Size = new Size(106, 29);
            pageSetupButton.TabIndex = 18;
            pageSetupButton.Text = "Page Setup";
            pageSetupButton.UseVisualStyleBackColor = false;
            pageSetupButton.Click += pageSetupButton_Click;
            // 
            // reportBox
            // 
            reportBox.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            reportBox.FormattingEnabled = true;
            reportBox.ItemHeight = 23;
            reportBox.Location = new Point(8, 26);
            reportBox.Margin = new Padding(4, 3, 4, 3);
            reportBox.Name = "reportBox";
            reportBox.Size = new Size(456, 418);
            reportBox.TabIndex = 17;
            // 
            // birthDate
            // 
            birthDate.CustomFormat = "yyyy/MM/dd";
            birthDate.Format = DateTimePickerFormat.Custom;
            birthDate.Location = new Point(130, 236);
            birthDate.Margin = new Padding(4, 3, 4, 3);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(213, 27);
            birthDate.TabIndex = 18;
            birthDate.UseWaitCursor = true;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Red;
            resetButton.ForeColor = SystemColors.Control;
            resetButton.Location = new Point(332, 701);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(89, 42);
            resetButton.TabIndex = 20;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.MediumTurquoise;
            AddButton.Location = new Point(543, 707);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(112, 42);
            AddButton.TabIndex = 22;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += Add_Click;
            // 
            // EmployeeTypeBox
            // 
            EmployeeTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EmployeeTypeBox.FormattingEnabled = true;
            EmployeeTypeBox.Items.AddRange(new object[] { "Employee", "Manager" });
            EmployeeTypeBox.Location = new Point(130, 115);
            EmployeeTypeBox.Margin = new Padding(4, 3, 4, 3);
            EmployeeTypeBox.Name = "EmployeeTypeBox";
            EmployeeTypeBox.Size = new Size(213, 28);
            EmployeeTypeBox.TabIndex = 24;
            EmployeeTypeBox.SelectedIndexChanged += EmployeeTypeBox_SelectedIndexChanged;
            // 
            // jobTxt
            // 
            jobTxt.Location = new Point(130, 303);
            jobTxt.Margin = new Padding(4, 3, 4, 3);
            jobTxt.Name = "jobTxt";
            jobTxt.Size = new Size(213, 27);
            jobTxt.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 303);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 25;
            label3.Text = "Job: ";
            // 
            // departmentTxt
            // 
            departmentTxt.Location = new Point(130, 336);
            departmentTxt.Margin = new Padding(4, 3, 4, 3);
            departmentTxt.Name = "departmentTxt";
            departmentTxt.Size = new Size(213, 27);
            departmentTxt.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 339);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 27;
            label8.Text = "Department: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 103);
            panel1.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(244, 27);
            label9.Name = "label9";
            label9.Size = new Size(454, 51);
            label9.TabIndex = 0;
            label9.Text = "Report Application";
            // 
            // IdList
            // 
            IdList.DropDownStyle = ComboBoxStyle.DropDownList;
            IdList.FormattingEnabled = true;
            IdList.Location = new Point(130, 149);
            IdList.Margin = new Padding(4, 3, 4, 3);
            IdList.Name = "IdList";
            IdList.Size = new Size(213, 28);
            IdList.TabIndex = 33;
            IdList.SelectedIndexChanged += IdList_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(90, 153);
            label11.Name = "label11";
            label11.Size = new Size(32, 20);
            label11.TabIndex = 34;
            label11.Text = "ID: ";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(661, 708);
            button1.Name = "button1";
            button1.Size = new Size(112, 42);
            button1.TabIndex = 35;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(779, 707);
            button2.Name = "button2";
            button2.Size = new Size(112, 42);
            button2.TabIndex = 36;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(25, 701);
            button3.Name = "button3";
            button3.Size = new Size(112, 42);
            button3.TabIndex = 37;
            button3.Text = "Show All";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 119);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 40;
            label7.Text = "Position: ";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(913, 782);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(IdList);
            Controls.Add(panel1);
            Controls.Add(departmentTxt);
            Controls.Add(label8);
            Controls.Add(jobTxt);
            Controls.Add(label3);
            Controls.Add(EmployeeTypeBox);
            Controls.Add(AddButton);
            Controls.Add(resetButton);
            Controls.Add(birthDate);
            Controls.Add(reportGroup);
            Controls.Add(resultButton);
            Controls.Add(arabicPerBar);
            Controls.Add(label6);
            Controls.Add(arabicPercent);
            Controls.Add(arabicLabel);
            Controls.Add(englishPerBar);
            Controls.Add(label5);
            Controls.Add(englishPercent);
            Controls.Add(englishLabel);
            Controls.Add(skillsBox);
            Controls.Add(statusList);
            Controls.Add(status);
            Controls.Add(gender);
            Controls.Add(nameLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application";
            Load += Form1_Load_1;
            gender.ResumeLayout(false);
            gender.PerformLayout();
            skillsBox.ResumeLayout(false);
            skillsBox.PerformLayout();
            reportGroup.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameLabel;
        private GroupBox gender;
        private RadioButton female;
        private RadioButton male;
        private Label status;
        private ComboBox statusList;
        private GroupBox skillsBox;
        private CheckBox cpp;
        private CheckBox java;
        private CheckBox csharp;
        private CheckBox computer;
        private Label englishLabel;
        private TextBox englishPercent;
        private Label label5;
        private ProgressBar englishPerBar;
        private ProgressBar arabicPerBar;
        private Label label6;
        private TextBox arabicPercent;
        private Label arabicLabel;
        private Button resultButton;
        private GroupBox reportGroup;
        private Button previewButton;
        private Button pageSetupButton;
        private ListBox reportBox;
        private Button printButton;
        private DateTimePicker birthDate;
        private Button resetButton;
        private PrintPreviewDialog printPreviewDialog1;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button AddButton;
        private ComboBox EmployeeTypeBox;
        private TextBox jobTxt;
        private Label label3;
        private TextBox departmentTxt;
        private Label label8;
        private Panel panel1;
        private Label label9;
        private ComboBox IdList;
        private Label label11;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
    }
}
