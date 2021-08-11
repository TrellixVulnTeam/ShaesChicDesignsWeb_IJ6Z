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

        public DbSet<WorkInquiry> WorkInquiries { get; set; }
    }
}
