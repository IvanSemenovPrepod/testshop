using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace WebApplication13.Models
{
    public class codesecond:DbContext
    {
        public DbSet<items> items { get; set; }

        public codesecond(DbContextOptions<codesecond> options)
           : base(options)
        {
            
        }
    }
}
