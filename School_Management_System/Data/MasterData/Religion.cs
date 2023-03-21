using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

using School_Management_System.Data.Entity;

namespace School_Management_System.Data.MasterData
{
    public class Religion:Base
    {
        [Required]
        [Column(TypeName = "NVARCHAR(150)")]
        public string name { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string shortName { get; set; }
    }
}
