using School_Management_System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Data.MasterData
{
    public class Country : Base
    {       
        [Column(TypeName = "NVARCHAR(20)")]
        public string countryCode { get; set; }        
        [Column(TypeName = "NVARCHAR(120)")]
        public string countryName { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string countryNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(20)")]
        public string shortName { get; set; }
        [Column(TypeName = "NVARCHAR(10)")]
        public string isActive { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string latitude { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string longitude { get; set; }
    }
}
