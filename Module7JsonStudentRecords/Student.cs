using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Module7JsonStudentRecords
{
    public class Student
    {
        // DisplayName makes it so that the raw variable names aren't shown in the data grid view.
        [DisplayName("ID")]
        public int StudentId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;
        [DisplayName("Last Name")]

        public string LastName { get; set; } = string.Empty;
        [DisplayName("Program Name")]

        public string ProgramName { get; set; } = string.Empty;
        public double GPA { get; set; }
    }
}
