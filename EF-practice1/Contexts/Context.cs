namespace EF_practice1.Contexts;

using EF_practice1.Entities.Concretes;
using Microsoft.EntityFrameworkCore;




public class Context : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string ConStr = "Data Source=DESKTOP-R8Q6LD3\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        optionsBuilder.UseSqlServer(ConStr);
        base.OnConfiguring(optionsBuilder);
    }


    public DbSet<Book>? Books { get; set; }

    public DbSet<Student>? Students { get; set; }

    public DbSet<Author>? Authors { get; set; }

    public DbSet<BookType>? BookTypes { get; set; }

    public DbSet<Operation>? Operations { get; set; }
}
