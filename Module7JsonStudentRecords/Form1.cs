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

        private void DisplayStudents(List<Student> records)
        {
            dgvStudentRecords.DataSource = null;
            dgvStudentRecords.DataSource = records;

            // make the data view look nicer
            dgvStudentRecords.Columns["StudentId"]!.Width = 50;
            dgvStudentRecords.Columns["FirstName"]!.Width = 100;
            dgvStudentRecords.Columns["LastName"]!.Width = 100;
            dgvStudentRecords.Columns["ProgramName"]!.Width = 150;
            dgvStudentRecords.Columns["GPA"]!.Width = 50;
            dgvStudentRecords.Columns["GPA"]!.DefaultCellStyle.Format = "N2";
        }

        private void LoadStudents()
        {
            string filePath = "students.json";
            try
            {
                string json = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(json)) throw new Exception("File is empty");

                students = JsonSerializer.Deserialize<List<Student>>(json)!;
                PopulateProgramCbo();
                DisplayStudents(students);
                lblResults.Text = $"Results: {students.Count} students loaded";
            }
            catch (FileNotFoundException) { lblResults.Text = "File not found"; }
            catch (JsonException) { lblResults.Text = "Invalid JSON format"; }
            catch (Exception e) { lblResults.Text = $"Error: {e.Message}"; }

            lblDetails.Text = "";
        }

        private void PopulateProgramCbo()
        {
            if (students.Count == 0) return;

            var programs = students
                .Select(student => student.ProgramName)
                .Distinct()
                .OrderBy(program => program)
                .ToArray();

            cboProgram.Items.Clear();
            cboProgram.Items.AddRange(programs);

            if (cboProgram.Items.Count > 0)
            {
                cboProgram.SelectedIndex = 0;
            }
        }

        private void FilterProgram()
        {
            if (cboProgram.SelectedItem == null)
            {
                lblResults.Text = "Please select a program";
                return;
            }
            string? selectedProgram = cboProgram.SelectedItem.ToString();

            var results = students
                .Where(student => string.Equals(student.ProgramName, selectedProgram, StringComparison.OrdinalIgnoreCase))
                .ToList();
            DisplayStudents(results);

            UpdateLabels(results.Count);
        }

        private void FilterGPA()
        {
            double minimumGPA = (double)numMinGPA.Value;

            if (minimumGPA < 0 || minimumGPA > 4.0)
            {
                lblResults.Text = "Validation Error";
                lblDetails.Text = "Invalid GPA, must be between 0.0 and 4.0";
                return;
            }

            var results = students
                .Where(student => student.GPA >= minimumGPA)
                .ToList();
            DisplayStudents(results);

            UpdateLabels(results.Count);
        }

        private void SearchStudents()
        {
            string searchText = txtQuery.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                lblResults.Text = "Validation Error";
                lblDetails.Text = "Please enter an ID or Name";
                return;
            }

            if (int.TryParse(searchText, out int studentId))
            {
                Student? result = students.FirstOrDefault(student => student.StudentId == studentId);
                if (result != null)
                {
                    DisplayStudents(new List<Student> { result });
                    lblResults.Text = "Results: 1 matching student";
                }
                else
                {
                    DisplayStudents(new List<Student>());
                    lblResults.Text = "No student found with that ID";
                }
                lblDetails.Text = "";
            }
            else
            {
                var results = students.Where(student =>
                    student.FirstName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    student.LastName.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();

                DisplayStudents(results);

                UpdateLabels(results.Count);
            }
        }

        private void SortLastName()
        {
            var results = students
                .OrderBy(student => student.LastName)
                .ThenBy(student => student.FirstName)
                .ToList();

            DisplayStudents(results);
            lblResults.Text = "Students sorted by Last Name";
            lblDetails.Text = "";
        }

        private void SortGPA()
        {
            var results = students
                .OrderByDescending(student => student.GPA)
                .ToList();
            DisplayStudents(results);
            lblResults.Text = "Students sorted by GPA";

            Student? topStudent = results.FirstOrDefault();
            lblDetails.Text = topStudent != null ? $"Highest: {topStudent.FirstName} {topStudent.LastName}" : "No students to sort";
        }

        private void RunCombinedQuery()
        {
            if (cboProgram.SelectedItem == null)
            {
                lblResults.Text = "Please select a program";
                return;
            }
            string? selectedProgram = cboProgram.SelectedItem.ToString();
            double minimumGPA = (double)numMinGPA.Value;

            if (minimumGPA < 0 || minimumGPA > 4.0)
            {
                lblResults.Text = "Invalid GPA, must be between 0.0 and 4.0";
                return;
            }

            var results = students
                .Where(student => string.Equals(student.ProgramName, selectedProgram, StringComparison.OrdinalIgnoreCase) && student.GPA >= minimumGPA)
                .OrderByDescending(student => student.GPA)
                .ToList();

            DisplayStudents(results);
            UpdateLabels(results.Count);
        }

        private void DisplaySummary()
        {
            if (students.Count == 0)
            {
                UpdateLabels(0, "Cannot calculate summary on an empty collection");
                return;
            }

            double avgGPA = students.Average(student => student.GPA);
            double highestGPA = students.Max(student => student.GPA);
            double lowestGPA = students.Min(student => student.GPA);
            int highGpaCount = students.Count(student => student.GPA >= 3.0);

            UpdateLabels(students.Count, $"Average GPA: {avgGPA:F2}  |  Highest GPA: {highestGPA:F2}  |  Lowest GPA: {lowestGPA:F2}  |  GPA ≥ 3.0: {highGpaCount}");
        }

        private void UpdateLabels(int resultCount, string detailText = "")
        {
            lblResults.Text = resultCount > 0 ? $"Results: {resultCount} matching students" : "No matching students found";
            lblDetails.Text = detailText;
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            DisplayStudents(students);
            lblResults.Text = $"Results: {students.Count} matching students";
        }

        private void BtnFilterProgram_Click(object sender, EventArgs e)
        {
            FilterProgram();
        }

        private void BtnFilterGPA_Click(object sender, EventArgs e)
        {
            FilterGPA();
        }

        private void BtnSearchStudent_Click(object sender, EventArgs e)
        {
            SearchStudents();
        }

        private void BtnSortLastName_Click(object sender, EventArgs e)
        {
            SortLastName();
        }

        private void BtnSortGPA_Click(object sender, EventArgs e)
        {
            SortGPA();
        }

        private void BtnCombinedQuery_Click(object sender, EventArgs e)
        {
            RunCombinedQuery();
        }

        private void BtnDisplaySummary_Click(object sender, EventArgs e)
        {
            DisplaySummary();
        }
    }
}
