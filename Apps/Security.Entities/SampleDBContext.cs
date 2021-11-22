using Microsoft.EntityFrameworkCore;
using Security.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Security.Models.ClassFiles
{
   public class SampleDBContext:DbContext
    {
        public SampleDBContext(DbContextOptions<SampleDBContext> options):base(options)
        {

        }
        public DbSet<SecurityInfo> SecurityMaster { get; set; }
    }
}
