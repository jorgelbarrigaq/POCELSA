using Elsa.Samples.UserRegistration.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elsa.Samples.UserRegistration.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<SolicitudGenerica> SolicitudesGenericas { get; set; }

        public DbSet<SolicitudGenericaLog> SolicitudesGenericasLogs { get; set; }

    }
}
