using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("BOOKDETAILS")]
public class BookDetails
{
    [Key]
    [Column("BOOKDETAIL_ID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BookDetailsId { get; set; }
    
    [Column("BOOKID"), Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int BookId { get; set; }
    
    public Book Book { get; set; }
    
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