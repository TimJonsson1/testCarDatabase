using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMvcLex1.Models;

namespace WebMvcLex1.Data
{
    public class WebMvcLex1Context : DbContext
    {
        public WebMvcLex1Context (DbContextOptions<WebMvcLex1Context> options)
            : base(options)
        {
        }

        public DbSet<WebMvcLex1.Models.Car> Car { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;
    }
}
