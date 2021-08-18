using System.Linq;

namespace WebAPI.Data
{
    public static class DbInitializer
    {
        public static void Seed(WorkContext context)
        {
            if (context.WorkInquiries.Any())
            {
                return;
            }

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.SaveChanges();
        }
    }
}
