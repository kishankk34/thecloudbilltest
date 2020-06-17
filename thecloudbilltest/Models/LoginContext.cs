using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thecloudbilltest.Models;

namespace thecloudbilltest.Models
{
    public class LoginContext:DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options):base(options)
        {

        }
        public DbSet<thecloudbilltest.Models.Login> Login { get; set; }
        public DbSet<thecloudbilltest.Models.Register> Register { get; set; }
    }
}
