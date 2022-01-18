using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public static class SeedData
    {
        // define an Initialize method that will insert data into our database
        // allow a parameter of type IServiceProvider to get access to registered services like the database context
        // we shall use this to create our initial books to the database
        public static void Initialize(IServiceProvider serviceProvider)
        {
            // create a scoped database context
            using (var context = new LibraryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LibraryContext>>()))
            {
                // Check if there are any Books in the database.
                if (context.Book.Any())
                {
                    return;   // If there are entries there, that means the db has been seeded
                }

                // if there arent any entries, we add our initial books into the db
                context.Book.AddRange(

                    // create a book called Tiny C#
                    new Book
                    {
                        Title = "Tiny C#",
                        CallNumber = "AXD 2029"
                    },
                    // create a book called Tiny Android
                    new Book
                    {
                        Title = "Tiny Android",
                        CallNumber = "KKZ 456"
                    }
                );

                // persist the books to the database
                context.SaveChanges();
            }
        }
    }
}