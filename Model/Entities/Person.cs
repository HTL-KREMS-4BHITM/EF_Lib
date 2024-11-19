using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

// Basisklasse für Personen 
[Table("PERSONS")]
public class Person { 
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public int Id { get; set; } 
    
    [Required, StringLength(50)]
    [Column("FIRSTNAME")]
    public string FirstName { get; set; } 
    
    [Required, StringLength(50)]
    [Column("LASTNAME")]
    public string LastName { get; set; } 
    
    [Required, Timestamp]
    [Column("DATEOFBIRTH")]
    public DateTime DateOfBirth { get; set; } 
} 
// Abgeleitete Klasse für Autoren
[Table("AUTHORS")]
public class Author : Person { 
    [Required, StringLength(500)]
    [Column("BIOGRAPHY")]
    public string Biography { get; set; } 
    
    [Column("BOOKS")]
    public List<Book> Books { get; set; }
} 
// Abgeleitete Klasse für Kunden 
[Table("CUSTOMERS")]
public class Customer : Person { 
    [Required, Timestamp]
    [Column("MEMBERSHIPDATE")]
    public DateTime MembershipDate { get; set; } 
} 
// Abgeleitete Klasse für Bibliothekare
[Table("LIBRARIANS")]
public class Librarian : Person { 
    [Required, StringLength(10)]
    [Column("EMPLOYEEID")]
    public string EmployeeId { get; set; } 
    
    [Column("BOOKLOANS")]
    public List<BookLoans> BookLoans { get; set; }
} 