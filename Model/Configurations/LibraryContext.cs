using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Configurations;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }
    
    public DbSet<Book> Books { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Librarian> Librarians { get; set; }
    public DbSet<BookDetails> BookDetails { get; set; }
    public DbSet<BookLoans> BookLoans { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Book>().HasDiscriminator<string>("ItemType")
            .HasValue<NonFiction>("NonFiction")
            .HasValue<Novel>("Novel")
            .HasValue<Textbook>("Textbook")
            .HasValue<Biography>("Biography")
            .HasValue<ScienceFiction>("ScienceFiction")
            .HasValue<Fantasy>("Fantasy")
            .HasValue<Mystery>("Mystery");
        
        builder.Entity<Author>().ToTable("AUTHORS");
        builder.Entity<Customer>().ToTable("CUSTOMERS");
        builder.Entity<Librarian>().ToTable("LIBRARIANS");
        
        builder.Entity<BookDetails>().HasOne(c => c.Book)
            .WithOne()
            .HasForeignKey<BookDetails>(c => c.BookId);
        
        //bidirektional wegen WithMany(List)
        builder.Entity<Book>().HasOne(c => c.AuthorInit)
            .WithMany(a => a.Books) 
            .HasForeignKey(c => c.AuthorId);
        
        builder.Entity<BookLoans>().HasOne(c => c.Book)
            .WithMany()
            .HasForeignKey(c => c.BookId);
        
        builder.Entity<BookLoans>().HasOne(c => c.Customer)
            .WithMany()
            .HasForeignKey(c => c.CustomerId);
        
        builder.Entity<BookLoans>().HasKey(o => new {o.BookId, o.CustomerId});
        
        builder.Entity<BookLoans>().HasOne(c => c.Librarian)
            .WithMany()
            .HasForeignKey(c => c.LibrarianId);
    }
}