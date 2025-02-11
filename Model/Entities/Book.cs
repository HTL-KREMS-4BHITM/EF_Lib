using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table(("Books"))]
public class Book { 
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public int Id { get; set; } 
    
    [Required, StringLength(45)]
    [Column("Title")]
    public string Title { get; set; } 
    
    [Required, StringLength(50)]
    [Column("Authors")]
    public string Author { get; set; }
    
    [Required, Timestamp]
    [Column("PublishedDate")]
    public DateTime PublishedDate { get; set; }
    
    [Required, StringLength(30)]
    [Column("ISBN")]
    public string ISBN { get; set; } 
    
    public BookDetails BookDetails { get; set; }
    
    [Required]
    [Column("BookDetailsID")]
    public int BookDetailsId { get; set; }
    
    public Author AuthorInit { get; set; }
    
    [Required]
    [Column("AuthorID")]
    public int AuthorId { get; set; }
} 
public class NonFiction : Book { } 
public class Novel : Book { } 
public class Textbook : Book { } 
public class Biography : Book { } 
public class ScienceFiction : Book { } 
public class Fantasy : Book { } 
public class Mystery : Book { } 
