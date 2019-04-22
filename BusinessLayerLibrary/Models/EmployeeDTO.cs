using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayerLibrary.Models
{
    public class EmployeeDTO
    {
        [Key]
        public int EmployeeId { get; set; }

        [StringLength(24)]
        public string INN { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateBirthday { get; set; }
    }
}
