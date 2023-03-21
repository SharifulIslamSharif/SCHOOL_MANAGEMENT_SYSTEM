using School_Management_System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Data.Auth
{
    public class UserType:Base
    {
        [Column(TypeName = "nvarchar(250)")]
        public string userTypeNameBn { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string userTypeName { get; set; }
        public int? shortOrder { get; set; }
    }
}
