using Model.Configurations;
using Model.Entities;

namespace Domain.Repository;

public class BookRepository : ARepository<BookDetails>
{
    protected BookRepository(LibraryContext context) : base(context)
    {
    }
}