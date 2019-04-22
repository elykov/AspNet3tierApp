using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Models
{
    public class EmpPromotionDTO
    {
        public int EmpPromotionId { get; set; }

        public int EmployeeId { get; set; }

        public int JobTitleId { get; set; }

        [Column(TypeName = "date")]
        public DateTime HireDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Salary { get; set; }

        public string FullName { get; set; }

        public string JobTitle { get; set; }

        //[Key]
        //public int EmpPromotionId { get; set; }

        //public int EmployeeId { get; set; }


        //public int JobTitleId { get; set; }


        //[Column(TypeName = "date")]
        //public DateTime HireDate { get; set; }

        //[Column(TypeName = "money")]
        //public decimal? Salary { get; set; }
    }
}
