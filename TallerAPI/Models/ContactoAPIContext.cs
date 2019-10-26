using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerAPI.Models
{
    public class ContactoAPIContext:DbContext
    {
        public ContactoAPIContext(DbContextOptions<ContactoAPIContext> options)
                    : base(options)
        {
        }

        public DbSet<ContactoAPI> ContactoAPIs { get; set; }
    }
}
