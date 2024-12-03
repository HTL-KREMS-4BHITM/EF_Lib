using Model.Configurations;
using Model.Entities;

namespace Domain.Repository;

public class BookDetailsRepository : ARepository<BookDetails>
{
    public BookDetailsRepository(LibraryContext context) : base(context)
    {
    }
}