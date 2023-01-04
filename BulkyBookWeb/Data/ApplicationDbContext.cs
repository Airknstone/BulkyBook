using BulkyBookWeb.Models; //imports Category model
using Microsoft.EntityFrameworkCore; //install entity framework core do allow DbContext base class

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)  //Constructor that accepts 1 parameter
        {

        }

        public DbSet<Category> Categories { get; set; } // sets up a table with the defined model categories in category
    }
}
