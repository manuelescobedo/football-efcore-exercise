using Infrastructure.Persistence;
using Shared;
using System.Text;

namespace Program;

public static class Program
{
    static void Main(string[] args)
    {
        using (AppDbContext ctx = new AppDbContext())
        {
            ctx.Database.EnsureCreated();

            var list = ctx.Stats.AsEnumerable();

            StringBuilder builder = new StringBuilder();
            CsvWriter.Write(builder, list);

            Console.WriteLine(builder.ToString());
        }
    }
}