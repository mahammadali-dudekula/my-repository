using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreCodeFirst.Entity
{
    [Table("T_ELite_Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("Brach")]
        [StringLength(200)]
        public string BranchName { get; set; }
    }
}
