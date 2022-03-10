using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int QId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string QInWords { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Options1 { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Options2 { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Options3 { get; set; }
        [Column(TypeName = "nvarchar(100)")]

        public string Options4 { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Options15 { get; set; }
        public int Answer { get; set; }

    }
}
