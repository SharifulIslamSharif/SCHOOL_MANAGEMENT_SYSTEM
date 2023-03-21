using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School_Management_System.Data.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public int? userTypeId { get; set; }
        public UserType userType { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string userCode { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }

        public decimal? MaxAmount { get; set; }

        public int? isActive { get; set; }
        [MaxLength(120)]
        public string org { get; set; }

        public DateTime? createdAt { get; set; }
        [MaxLength(120)]
        public string createdBy { get; set; }

        public DateTime? updatedAt { get; set; }
        [MaxLength(120)]
        public string updatedBy { get; set; }
    }
}
