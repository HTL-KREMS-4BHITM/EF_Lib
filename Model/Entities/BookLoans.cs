using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace Model.Entities;

[Table("BOOKLOANS")]
public class BookLoans
{
    public Book Book { get; set; }
    
    [Column("BOOKID", TypeName = "int")]
    public int BookId { get; set; }
    
    public Customer Customer { get; set; }
    
    [Column("CUSTOMERID", TypeName = "int")]
    public int CustomerId { get; set; }
    
    [Required]
    [Column("LOANDATE")]
    public DateTime LoanDate { get; set; }
    
    [Required, Timestamp]
    [Column("DUEDATE")]
    public DateTime DueDate { get; set; }
    
    public Librarian Librarian { get; set; }
    
    [Required]
    [Column("LIBRARIANID", TypeName = "int")]
    public int LibrarianId { get; set; }
    
    public Librarian ReturnLibrarian { get; set; }
    
    [Column("RETURNLIBRARIANID", TypeName = "int")]
    public int? ReturnLibrarianId { get; set; }
    
    [Timestamp]
    [Column("RETURNDATE")]
    public DateTime? ReturnDate { get; set; }
    
    
}