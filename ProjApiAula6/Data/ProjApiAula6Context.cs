using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjApiAula6.Models;

namespace ProjApiAula6.Data
{
    public class ProjApiAula6Context : DbContext
    {
        public ProjApiAula6Context (DbContextOptions<ProjApiAula6Context> options)
            : base(options)
        {
        }

        public DbSet<ProjApiAula6.Models.Client> Client { get; set; }
    }
}
