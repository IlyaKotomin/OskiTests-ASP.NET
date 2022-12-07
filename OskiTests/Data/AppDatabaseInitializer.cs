using OskiTests.Models;

namespace OskiTests.Data
{
    public class AppDatabaseInitializer
    {
        public static void Seed(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDataBaseContext>()!;

                context.Database.EnsureCreated();


            }
        }
    }
}
