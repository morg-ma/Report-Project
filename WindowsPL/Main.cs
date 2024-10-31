using BusinessLayer;
using DataAccessLayer.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WindowsPL
{
    public partial class Main : Form
    {
        private EmployeeBL empBL;

        public Main()
        {
            InitializeComponent();
            empBL = new EmployeeBL();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Set initial properties if needed
            englishPerBar.Minimum = 0;
            englishPerBar.Maximum = 100;

            arabicPerBar.Minimum = 0;
            arabicPerBar.Maximum = 100;

            UpdateProgressBar(englishPercent, englishPerBar);

            UpdateProgressBar(arabicPercent, arabicPerBar);

            statusList.SelectedIndex = 0;
            EmployeeTypeBox.SelectedIndex = 0;

            FillComboIds();

        }

        #region LanguagesScores
        private void englishPercent_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(englishPercent, englishPerBar);
        }

        private void arabicPercent_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(arabicPercent, arabicPerBar);
        }

        private void UpdateProgressBar(TextBox langPercent, ProgressBar langBar)
        {
            if (int.TryParse(langPercent.Text, out int percentage) || langPercent.Text == "")
            {
                if (percentage >= 0 && percentage <= 100)
                {
                    langBar.Value = percentage;
                }
                else
                {
                    MessageBox.Show("Please enter a value between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    langPercent.Text = string.Empty;
                    langPercent.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                langPercent.Text = string.Empty;
                langPercent.Focus();
            }
        }
        #endregion

        private void resultButton_Click(object sender, EventArgs e)
        {
            if (nameLabel == null || nameLabel.Text.Trim() == "")
            {
                MessageBox.Show("Enter your Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameLabel.Focus();
                return;
            }
            if (birthDate.Value.Year == DateTime.Now.Year)
            {
                MessageBox.Show("Enter valid Birthdate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string skills = GetSkillsValue(java, cpp, computer, csharp);
            if (skills.Length > 2)
                skills = skills.Substring(0, skills.Length - 1);

            reportBox.Items.Clear();
            Employee emp = new Employee();
            emp.Name = nameLabel.Text;
            emp.Birthdate = birthDate.Value;
            string status = statusList.SelectedItem.ToString();
            emp.Status = status == null ? "" : status;
            emp.Gender = GetGenderValue(male, female);
            emp.Job = jobTxt.Text;
            emp.Department = departmentTxt.Text;
            emp.Skills = skills;
            int.TryParse(englishPercent.Text, out int eng);
            emp.English = eng;
            int.TryParse(arabicPercent.Text, out int arb);
            emp.Arabic = arb;
            reportBox.Items.AddRange(ShowResults(emp).Items);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Clean_Fields();
        }

        public void Clean_Fields()
        {
            nameLabel.Text = string.Empty;
            birthDate.Value = DateTime.Now;
            statusList.Text = string.Empty;
            male.Checked = true;
            female.Checked = false;
            statusList.SelectedIndex = 0;
            cpp.Checked = false;
            java.Checked = false;
            csharp.Checked = false;
            computer.Checked = false;
            jobTxt.Text = string.Empty;
            departmentTxt.Text = string.Empty;
            SetSkillsValue(string.Empty);
            englishPercent.Text = string.Empty;
            arabicPercent.Text = string.Empty;

            reportBox.Items.Clear();
        }

        #region PrintButtons
        private void pageSetupButton_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(reportBox.Text, new Font("Franklin Gothic Medium Cond", 16), Brushes.Black, 10, 10);
        }

        #endregion

        private void Add_Click(object sender, EventArgs e)
        {
            if (nameLabel == null || nameLabel.Text.Trim() == "")
            {
                MessageBox.Show("Enter your Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameLabel.Focus();
                return;
            }

            if (birthDate.ToString() == DateTime.Now.ToString())
            {
                MessageBox.Show("Enter valid Birthdate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string skills = GetSkillsValue(java, csharp, cpp, computer);
            if (skills.Length > 2)
                skills = skills.Substring(0, skills.Length - 1); // pass the value without the last ", "

            Employee emp = new Employee();
            emp.Name = nameLabel.Text;
            emp.Birthdate = birthDate.Value;
            string status = statusList.SelectedItem.ToString();
            emp.Status = status == null ? "" : status;
            emp.Gender = GetGenderValue(male, female);
            emp.Job = jobTxt.Text;
            emp.Department = departmentTxt.Text;
            emp.Skills = skills;
            int.TryParse(englishPercent.Text, out int eng);
            emp.English = eng;
            int.TryParse(arabicPercent.Text, out int arb);
            emp.Arabic = arb;
            if (EmployeeTypeBox.Text == "Employee") // Employee
            {
                emp.EmployeeType = "Employee";
                MessageBox.Show($"Employee {emp.Name} saved successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Manager
            {
                emp.EmployeeType = "Manager";
                MessageBox.Show($"Manager {emp.Name} saved successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            empBL.AddEmployee(emp);
            reportBox.Items.AddRange(ShowResults(emp).Items);
            Clean_Fields();
            FillComboIds();
        }


        private static string GetSkillsValue(params CheckBox[] skillsBox)
        {
            string skills = "";
            foreach (CheckBox checkBox in skillsBox)
            {
                if (checkBox.Checked)
                {
                    skills += checkBox.Text + ',';
                }
            }
            return skills;
        }

        private static string GetGenderValue(params RadioButton[] genderButton)
        {
            if (genderButton[1].Checked)
                return "Female";
            return "Male";
        }

        private static ListBox ShowResults(Employee emp)
        {
            ListBox report = new ListBox();
            report.Items.Add("----------------------------------- Your Information ----------------------------------");
            report.Items.Add($"Name: {emp.Name}");
            report.Items.Add("-----------------------------------------------------------------------------------------");
            report.Items.Add($"Date of birth: {emp.Birthdate}");
            if (emp.Age == -1)
                report.Items.Add($"Age: ");
            else
                report.Items.Add($"Age: {emp.Age}");
            report.Items.Add("-----------------------------------------------------------------------------------------");
            report.Items.Add($"Gender: {emp.Gender}");
            report.Items.Add($"Mstatus: {emp.Status}");
            report.Items.Add($"Job: {emp.Job}");
            report.Items.Add($"Department: {emp.Department}");
            report.Items.Add($"Skills: {emp.Skills}");
            report.Items.Add($"English language: {emp.English}%");
            report.Items.Add($"Arabic language: {emp.Arabic}%");
            report.Items.Add("------------------------------------------ END -----------------------------------------");

            return report;
        }

        private void FillComboIds()
        {
            IdList.Items.Clear();

            if (EmployeeTypeBox.Text == "Employee")
                IdList.Items.AddRange(empBL.GetEmployeesIds().ToArray());
            if (EmployeeTypeBox.Text == "Manager")
                IdList.Items.AddRange(empBL.GetManagersIds().ToArray());
        }

        private void IdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clean_Fields();
            dynamic emp = empBL.GetEmployeeById((int)IdList.SelectedItem);
            if (emp == null)
                return;
            nameLabel.Text = emp.Name;
            birthDate.Value = emp.Birthdate;
            statusList.Text = emp.Status.ToString();
            if (emp.Gender == "Male") // Male
                male.Checked = true;
            else // Female
                female.Checked = true;
            jobTxt.Text = emp.Job;
            departmentTxt.Text = emp.Department;
            SetSkillsValue(emp.Skills);
            englishPercent.Text = emp.English.ToString();
            arabicPercent.Text = emp.Arabic.ToString();
            reportBox.Items.AddRange(ShowResults(emp).Items);
        }

        private void SetSkillsValue(string skills)
        {
            if (string.IsNullOrEmpty(skills))
                return;
            string[] skillsList = skills.Split(',');
            foreach (string sk in skillsList)
            {
                if (sk == java.Text)
                    java.Checked = true;
                if (sk == csharp.Text)
                    csharp.Checked = true;
                if (sk == cpp.Text)
                    cpp.Checked = true;
                if (sk == computer.Text)
                    computer.Checked = true;
            }
        }

        private void EmployeeTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboIds();
            Clean_Fields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EmployeeTypeBox.SelectedIndex == 0)
                new ShowInfo(empBL.GetAllEmployees(), empBL.GetEmployeeCount(), "Employee").Show();

            else
                new ShowInfo(empBL.GetAllManagers(), empBL.GetManagerCount(), "Manager").Show();
        }

        // Update button
        private void button1_Click(object sender, EventArgs e)
        {
            if (nameLabel == null || nameLabel.Text.Trim() == "")
            {
                MessageBox.Show("Enter your Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameLabel.Focus();
                return;
            }

            if (birthDate.ToString() == DateTime.Now.ToString())
            {
                MessageBox.Show("Enter valid Birthdate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string skills = GetSkillsValue(java, csharp, cpp, computer);
            if (skills.Length > 2)
                skills = skills.Substring(0, skills.Length - 1); // pass the value without the last ", "

            Employee emp = new Employee();
            emp.Id = (int)IdList.SelectedItem;
            emp.Name = nameLabel.Text;
            emp.Birthdate = birthDate.Value;
            string status = statusList.SelectedItem.ToString();
            emp.Status = status == null ? "" : status;
            emp.Gender = GetGenderValue(male, female);
            emp.Job = jobTxt.Text;
            emp.Department = departmentTxt.Text;
            emp.Skills = skills;
            int.TryParse(englishPercent.Text, out int eng);
            emp.English = eng;
            int.TryParse(arabicPercent.Text, out int arb);
            emp.Arabic = arb;
            reportBox.Items.AddRange(ShowResults(emp).Items);

            Clean_Fields();

            empBL.UpdateEmployee(emp);

            if (EmployeeTypeBox.Text == "Employee") // Employee
                MessageBox.Show($"Employee {emp.Name} updated successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else // Manager
                MessageBox.Show($"Manager {emp.Name} updated successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Delete button
        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)IdList.SelectedItem;
            string name = empBL.GetEmployeeById(id).Name;
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {name}?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                empBL.DeleteEmployee(id);
                MessageBox.Show($"{name} deleted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean_Fields();
                FillComboIds();
            }
            else
            {
                return;
            }


        }
    }
}
