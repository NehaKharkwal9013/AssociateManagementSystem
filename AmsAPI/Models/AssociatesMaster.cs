using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmsAPI.Models
{
    public class AssociatesMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssociateId { get; set; }

        [Column (TypeName="nvarchar(100)")]
        public string AssociateName { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Phone { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Address { get; set; }

        //Foreign Key
        [ForeignKey("SpecializationMaster")]
        public int SpecializationId { get; set; }

        //Navigation key
        public SpecializationMaster SpecializationMaster { get; set; }
    }
}
