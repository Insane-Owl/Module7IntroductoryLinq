using System.Drawing.Text;
using System.Text.Json;
using System.IO;
using System.Linq;
namespace Module7JsonStudentRecords
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            LoadStudents();
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

        private void LoadStudents()
        {
            string filePath = "students.json";
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
    }
}
