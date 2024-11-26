using Model.Configurations;
using Model.Entities;

namespace Domain.Repository;

public class AuthorRepository:ARepository<Author>
{
    public AuthorRepository(LibraryContext config) : base(config)
    {
    }
}