using Model.Configurations;
using Model.Entities;

namespace Domain.Repository;

public class BooksRepository:ARepository<Book>
{
    public BooksRepository(LibraryContext config) : base(config)
    {
    }
}