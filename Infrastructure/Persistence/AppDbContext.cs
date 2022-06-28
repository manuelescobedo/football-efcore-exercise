using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infrastructure.Persistence;

public class AppDbContext : DbContext
{

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Match>(x =>
        {

            x.ToTable("Matches").HasKey(g => g.ID);
            x.HasData(
                new Match { ID = 1, Local = "Canada", Visitor = "Mexico", LocalScore = 2, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Canada" },
                new Match { ID = 2, Local = "Canada", Visitor = "United States", LocalScore = 2, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Canada" },
                new Match { ID = 3, Local = "Canada", Visitor = "Costa Rica", LocalScore = 1, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Canada" },
                new Match { ID = 4, Local = "Canada", Visitor = "Panama", LocalScore = 4, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Canada" },
                new Match { ID = 5, Local = "Canada", Visitor = "Jamaica", LocalScore = 4, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Canada" },
                new Match { ID = 6, Local = "Canada", Visitor = "El Salvador", LocalScore = 3, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Canada" },
                new Match { ID = 7, Local = "Canada", Visitor = "Honduras", LocalScore = 1, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Canada" },
                new Match { ID = 8, Local = "Mexico", Visitor = "Canada", LocalScore = 1, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Mexico" },
                new Match { ID = 9, Local = "Mexico", Visitor = "United States", LocalScore = 0, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Mexico" },
                new Match { ID = 10, Local = "Mexico", Visitor = "Costa Rica", LocalScore = 0, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Mexico" },
                new Match { ID = 11, Local = "Mexico", Visitor = "Panama", LocalScore = 1, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Mexico" },
                new Match { ID = 12, Local = "Mexico", Visitor = "Jamaica", LocalScore = 2, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Mexico" },
                new Match { ID = 13, Local = "Mexico", Visitor = "El Salvador", LocalScore = 2, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Mexico" },
                new Match { ID = 14, Local = "Mexico", Visitor = "Honduras", LocalScore = 3, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Mexico" },
                new Match { ID = 15, Local = "United States", Visitor = "Canada", LocalScore = 1, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "United States" },
                new Match { ID = 16, Local = "United States", Visitor = "Mexico", LocalScore = 2, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "United States" },
                new Match { ID = 17, Local = "United States", Visitor = "Costa Rica", LocalScore = 2, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "United States" },
                new Match { ID = 18, Local = "United States", Visitor = "Panama", LocalScore = 5, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "United States" },
                new Match { ID = 19, Local = "United States", Visitor = "Jamaica", LocalScore = 2, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "United States" },
                new Match { ID = 20, Local = "United States", Visitor = "El Salvador", LocalScore = 1, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "United States" },
                new Match { ID = 21, Local = "United States", Visitor = "Honduras", LocalScore = 3, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "United States" },
                new Match { ID = 22, Local = "Costa Rica", Visitor = "Canada", LocalScore = 1, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Costa Rica" },
                new Match { ID = 23, Local = "Costa Rica", Visitor = "Mexico", LocalScore = 0, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Costa Rica" },
                new Match { ID = 24, Local = "Costa Rica", Visitor = "United States", LocalScore = 2, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Costa Rica" },
                new Match { ID = 25, Local = "Costa Rica", Visitor = "Panama", LocalScore = 1, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Costa Rica" },
                new Match { ID = 26, Local = "Costa Rica", Visitor = "Jamaica", LocalScore = 1, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Costa Rica" },
                new Match { ID = 27, Local = "Costa Rica", Visitor = "El Salvador", LocalScore = 2, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Costa Rica" },
                new Match { ID = 28, Local = "Costa Rica", Visitor = "Honduras", LocalScore = 2, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Costa Rica" },
                new Match { ID = 29, Local = "Panama", Visitor = "Canada", LocalScore = 1, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Panama" },
                new Match { ID = 30, Local = "Panama", Visitor = "Mexico", LocalScore = 1, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Panama" },
                new Match { ID = 31, Local = "Panama", Visitor = "United States", LocalScore = 1, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Panama" },
                new Match { ID = 32, Local = "Panama", Visitor = "Costa Rica", LocalScore = 0, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Panama" },
                new Match { ID = 33, Local = "Panama", Visitor = "Jamaica", LocalScore = 3, VisitorScore = 2, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Panama" },
                new Match { ID = 34, Local = "Panama", Visitor = "El Salvador", LocalScore = 2, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Panama" },
                new Match { ID = 35, Local = "Panama", Visitor = "Honduras", LocalScore = 1, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Panama" },
                new Match { ID = 36, Local = "Jamaica", Visitor = "Canada", LocalScore = 0, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Jamaica" },
                new Match { ID = 37, Local = "Jamaica", Visitor = "Mexico", LocalScore = 1, VisitorScore = 2, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Jamaica" },
                new Match { ID = 38, Local = "Jamaica", Visitor = "United States", LocalScore = 1, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Jamaica" },
                new Match { ID = 39, Local = "Jamaica", Visitor = "Costa Rica", LocalScore = 0, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Jamaica" },
                new Match { ID = 40, Local = "Jamaica", Visitor = "Panama", LocalScore = 0, VisitorScore = 3, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Jamaica" },
                new Match { ID = 41, Local = "Jamaica", Visitor = "El Salvador", LocalScore = 1, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Jamaica" },
                new Match { ID = 42, Local = "Jamaica", Visitor = "Honduras", LocalScore = 2, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Jamaica" },
                new Match { ID = 43, Local = "El Salvador", Visitor = "Canada", LocalScore = 0, VisitorScore = 2, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "El Salvador" },
                new Match { ID = 44, Local = "El Salvador", Visitor = "Mexico", LocalScore = 0, VisitorScore = 2, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "El Salvador" },
                new Match { ID = 45, Local = "El Salvador", Visitor = "United States", LocalScore = 0, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "El Salvador" },
                new Match { ID = 46, Local = "El Salvador", Visitor = "Costa Rica", LocalScore = 1, VisitorScore = 2, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "El Salvador" },
                new Match { ID = 47, Local = "El Salvador", Visitor = "Panama", LocalScore = 1, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "El Salvador" },
                new Match { ID = 48, Local = "El Salvador", Visitor = "Jamaica", LocalScore = 1, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "El Salvador" },
                new Match { ID = 49, Local = "El Salvador", Visitor = "Honduras", LocalScore = 0, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "El Salvador" },
                new Match { ID = 50, Local = "Honduras", Visitor = "Canada", LocalScore = 0, VisitorScore = 2, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Honduras" },
                new Match { ID = 51, Local = "Honduras", Visitor = "Mexico", LocalScore = 0, VisitorScore = 1, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Honduras" },
                new Match { ID = 52, Local = "Honduras", Visitor = "United States", LocalScore = 1, VisitorScore = 4, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Honduras" },
                new Match { ID = 53, Local = "Honduras", Visitor = "Costa Rica", LocalScore = 0, VisitorScore = 0, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Honduras" },
                new Match { ID = 54, Local = "Honduras", Visitor = "Panama", LocalScore = 2, VisitorScore = 3, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Honduras" },
                new Match { ID = 55, Local = "Honduras", Visitor = "Jamaica", LocalScore = 0, VisitorScore = 2, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Honduras" },
                new Match { ID = 56, Local = "Honduras", Visitor = "El Salvador", LocalScore = 0, VisitorScore = 2, Date = DateTime.Parse("2022-06-25T00:00:00"), Ground = "Honduras" }
            );
        });

        

        modelBuilder.Entity<TeamStats>(t =>
        {
            t.HasNoKey();
            t.ToView("vmStats");
        });
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var dbPath = @"C:\Users\m.escobedo.escareno\Documents\football\football.db";//Environment.GetEnvironmentVariable("DBPATH");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }


    public DbSet<Match> Matches { get; set; }
    public DbSet<TeamStats> Stats { get; set; }

}
