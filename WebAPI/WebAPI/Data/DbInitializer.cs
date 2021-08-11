namespace WebAPI.Data
{
    public static class DbInitializer
    {
        public static void Seed(WorkContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.SaveChanges();
        }
    }
}
