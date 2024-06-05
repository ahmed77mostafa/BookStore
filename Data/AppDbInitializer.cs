using wTickets.Models;

namespace wTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<dbContext>();

                context.Database.EnsureCreated();

                if (!context.Actor.Any())
                {
                    context.Actor.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            // Add proberties
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
