using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class WorkContext : DbContext
    {
        public WorkContext(DbContextOptions<WorkContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkInquiry>()
              .HasKey(p => new { p.WorkInquiryId });
        }

        public DbSet<WorkInquiry> WorkInquiries { get; set; }
    }
}
