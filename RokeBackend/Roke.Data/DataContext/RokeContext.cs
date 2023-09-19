using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Roke.Core.Model;
using RokeBackend.Model;

namespace RokeBackend.data.DataContext
{
    public partial class RokeContext : DbContext
    {

        public RokeContext(DbContextOptions<RokeContext> options)
            : base(options)
        {
        }


        public DbSet<user> users { get; set; }
        public DbSet<Ticket>tickets{get;set;}
        public DbSet<location> location { get; set; }
        public DbSet<month> months { get; set; }
        public DbSet<Template> template { get; set; }

        public  DbSet<TemplateLocationMapping> templateLocationMapping { get; set; }
        public DbSet<brigade> brigades { get; set; }
        public DbSet<brigadeAssigne> brigadeAssinge { get; set; }
    }
}
