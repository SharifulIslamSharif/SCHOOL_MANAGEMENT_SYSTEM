using System;
using System.Collections.Generic;
using System.Text;

namespace School_Management_System.Data.Entity
{
    public class Resultsheet :Base
    {
        public string Subject { get; set; }
        public int TotalMarks { get; set; }
        public string Grade { get; set; }
        public int? studentInfoId { get; set; }
        public StudentInfo studentInfo { get; set; }
    }
}
