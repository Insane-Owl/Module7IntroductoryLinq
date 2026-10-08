using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Module7JsonStudentRecords
{
    public class Student
    {
        [DisplayName("ID")]
        public int StudentId { get; set; }
        [DisplayName("First Name")]
        public required string FirstName { get; set; }
        [DisplayName("Last Name")]

        public required string LastName { get; set; }
        [DisplayName("Program Name")]

        public required string ProgramName { get; set; }
        public double GPA { get; set; }
    }
}
