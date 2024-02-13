namespace EF_practice1.Contexts;

using EF_practice1.Entities;
using Microsoft.EntityFrameworkCore;


internal class LibraryContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string str = "Data Source=DESKTOP-R8Q6LD3\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        optionsBuilder.UseSqlServer(str);
        base.OnConfiguring(optionsBuilder);
    }

    // Tables
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<BookType> BookTypes { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Operation> Operations { get; set; }
}
