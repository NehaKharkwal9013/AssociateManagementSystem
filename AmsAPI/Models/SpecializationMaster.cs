using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmsAPI.Models
{
    public class SpecializationMaster
    {
        [Key]
        public int SpecializationId { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string SpecializationName { get; set; }
    }
}
