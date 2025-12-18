using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitalPortal.Models;

namespace HostpitalPortal.Data
{
    public class HostpitalPortalContext : DbContext
    {
        public HostpitalPortalContext (DbContextOptions<HostpitalPortalContext> options)
            : base(options)
        {
        }

        public DbSet<HospitalPortal.Models.Patient> Patient { get; set; } = default!;
    }
}
