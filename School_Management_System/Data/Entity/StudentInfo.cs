using School_Management_System.Data.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace School_Management_System.Data.Entity
{
    public class StudentInfo : Base
    {
        public string Name { get; set; }
        public string Roll { get; set; }
        public string Address { get; set; }
        public int? sectionId { get; set; }
        public Section section { get; set; }
        public int? classInfoId { get; set; }
        public ClassInfo classInfo { get; set; }
        public int? genderId { get; set; }
        public Gender gender { get; set; }
        public int? isActive { get; set; }
        public string url { get; set; }
        //Application User LInk
        public String ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}

