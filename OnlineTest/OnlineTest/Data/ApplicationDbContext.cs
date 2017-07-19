using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineTest.Models;

namespace OnlineTest.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> user { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<Test> test { get; set; }
        public DbSet<FinalResult> finalresult { get; set; }
        public DbSet<SubCategory> subcategory { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<FeedBack> feedback { get; set; }
        public DbSet<UserQA> userqa { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
