using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Models
{
    public class JobTitleDTO
    {
        public int JobTitleId { get; set; }

        [Required]
        [StringLength(100)]
        public string NameJobTitle { get; set; }
    }
}
