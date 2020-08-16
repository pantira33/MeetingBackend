using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class Detail
    {
        [Key]
        public int DetailId { get; set; }
        [Required]
        [Column(TypeName="varchar(100)")]
        public string Title { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string MeetingNo { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Location { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string DMY { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Details { get; set; }

       





    }
}
