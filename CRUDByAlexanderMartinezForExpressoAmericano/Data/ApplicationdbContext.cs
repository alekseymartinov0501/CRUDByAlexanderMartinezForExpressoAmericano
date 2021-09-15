using CRUDByAlexanderMartinezForExpressoAmericano.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDByAlexanderMartinezForExpressoAmericano.Data
{
    public class ApplicationdbContext : DbContext
    {

        public ApplicationdbContext(DbContextOptions<ApplicationdbContext> options) :base(options)
        {
        }

        public DbSet<Producto> Producto { get; set; }

    }
}
