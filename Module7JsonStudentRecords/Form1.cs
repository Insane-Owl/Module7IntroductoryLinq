using System.Drawing.Text;
using System.Text.Json;
using System.IO;
namespace Module7JsonStudentRecords
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();

        }

        private void AddStudent()
        {
            if (!ValidateInput()) return;

            students.Add(new Student
            {
                StudentId = (int)numStudentId.Value,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                ProgramName = txtProgramName.Text,
                GPA = (double)numGPA.Value
            });

            DisplayStudents();
            ClearInputFields();
            lblStatus.Text = "Student added successfully.";
        }

        private bool ValidateInput()
        {
            if (numStudentId.Value <= 0 || string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtProgramName.Text) ||
                numGPA.Value < 0 || numGPA.Value > 4)
            {
                lblStatus.Text = "Invalid input. Please check all fields.";
                return false;
            }
            return true;
        }

        private void DisplayStudents()
        {
            dgvStudentRecords.DataSource = null;
            dgvStudentRecords.DataSource = students;

            // make the data view look nicer
            dgvStudentRecords.Columns["StudentId"]!.Width = 50;
            dgvStudentRecords.Columns["FirstName"]!.Width = 100;
            dgvStudentRecords.Columns["LastName"]!.Width = 100;
            dgvStudentRecords.Columns["ProgramName"]!.Width = 150;
            dgvStudentRecords.Columns["GPA"]!.Width = 50;
        }

        private void ClearDisplay()
        {
            students.Clear();
            DisplayStudents();
            lblStatus.Text = "Display cleared.";
        }

        private void SaveStudents()
        {
            if (students.Count == 0)
            {
                lblStatus.Text = "No students to save.";
                return;
            }

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string filePath = Path.Combine(Application.StartupPath, "students.json");
            string json = JsonSerializer.Serialize(students, options);
            File.WriteAllText(filePath, json);
            lblStatus.Text = $"Students saved to students.json.";
        }

        private void LoadStudents()
        {
            string filePath = Path.Combine(Application.StartupPath, "students.json");
            try
            {
                string json = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(json)) throw new Exception("File is empty.");

                students = JsonSerializer.Deserialize<List<Student>>(json)!;
                DisplayStudents();
                lblStatus.Text = "Records loaded.";
            }
            catch (FileNotFoundException) { lblStatus.Text = "File not found."; }
            catch (JsonException) { lblStatus.Text = "Invalid JSON format."; }
            catch (Exception e) { lblStatus.Text = $"Error: {e.Message}"; }
        }

        private void ClearInputFields()
        {
            numStudentId.Value = 0;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtProgramName.Clear();
            numGPA.Value = 0;
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDisplay();
        }

        private void btnSaveJSON_Click(object sender, EventArgs e)
        {
            SaveStudents();
        }

        private void btnLoadJSON_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
