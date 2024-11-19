using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("BOOKDETAILS")]
public class BookDetails
{
    [Key]
    [Column("BOOKID", TypeName = "int")]
    public int BookId { get; set; }
    
    [Required]
    [Column("TOTALCOPIES", TypeName = "int")]
    public int TotalCopies { get; set; }
    
    [Required]
    [Column("BORROWEDCOPIES", TypeName = "int")]
    public int BorrowedCopies { get; set; }
    
    [Required]
    [Column("AVAILABLECOPIES", TypeName = "int")]
    public int AvailableCopies { get; set; }
    
}