using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First.Models
{
    [Table("Categories")]
    public class Category : DomainObject
    {
        [Column("Name")]
        [Required]
        [StringLength(50)]
        public string? Name { get; set; } = string.Empty;
    }
}
    