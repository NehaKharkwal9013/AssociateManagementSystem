using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmsAPI.Models
{
    public class AssociateMasterContext : DbContext
    {
        public AssociateMasterContext(DbContextOptions<AssociateMasterContext>options): base(options)
        {

        }
         public DbSet<AssociatesMaster> AssociatesMasters { get; set; }
         public DbSet<SpecializationMaster> SpecializationMasters { get; set; }


    }
}
