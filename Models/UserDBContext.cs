using Microsoft.EntityFrameworkCore;

namespace graphql_dotnet.Models;

public class UserDBContext : DbContext
{
    public UserDBContext(DbContextOptions<UserDBContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Phone> Phones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "Alice" },
            new User { Id = 2, Name = "Bob" },
            new User { Id = 3, Name = "Cathy" },
            new User { Id = 4, Name = "Daisy" },
            new User { Id = 5, Name = "Eve" }
        );

        modelBuilder.Entity<Phone>().HasData(
            new Phone { Id = 1, UserId = 1, Number = "111-111-1111" },
            new Phone { Id = 2, UserId = 1, Number = "222-222-2222" },
            new Phone { Id = 3, UserId = 2, Number = "333-333-3333" },
            new Phone { Id = 4, UserId = 2, Number = "444-444-4444" },
            new Phone { Id = 5, UserId = 3, Number = "555-555-5555" },
            new Phone { Id = 6, UserId = 3, Number = "666-666-6666" },
            new Phone { Id = 7, UserId = 4, Number = "777-777-7777" },
            new Phone { Id = 8, UserId = 4, Number = "888-888-8888" },
            new Phone { Id = 9, UserId = 5, Number = "999-999-9999" },
            new Phone { Id = 10, UserId = 5, Number = "000-000-0000" }
        );
    }
}