using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Week7Assignment.Data;

namespace Week7Assignment.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Week7AssignmentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Week7AssignmentContext>>()))
            {
                // Look for any entries.
                if (context.Entry.Any())
                {
                    return;      // DB has been seeded
                }

                context.Entry.AddRange(
                    new Entry
                    {
                        DateAdded = DateTime.Now,
                        Book = "1 Nephi",
                        Chapter = 1,
                        Verse = 1,
                        Note = "And so it begins..."

                    },

                    new Entry
                    {
                        DateAdded = DateTime.Now,
                        Book = "Genesis",
                        Chapter = 1,
                        Verse = 1,
                        Note = "The VERY beginning"

                    }
                );
                context.SaveChanges();
                
            }
        }
    }
}
