using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserService.Data
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
    }
}
