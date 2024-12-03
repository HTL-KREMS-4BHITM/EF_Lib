using System.Linq.Expressions;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repository;

public class ARepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly LibraryContext _context;
    private readonly DbSet<TEntity> _table;

    protected ARepository(LibraryContext context)
    {
        _context = context;
        _table = context.Set<TEntity>();
    }
    public TEntity Create(TEntity t)
    {
        _table.Add(t);
        _context.SaveChanges();
        return t;
    }

    public List<TEntity> CreateRange(List<TEntity> list)
    {
        _table.AddRange(list);
        _context.SaveChanges();
        return list;
    }

    public void Update(TEntity t)
    {
            _context.SaveChanges();
            _table.Attach(t);
            _table.Update(t);
            _context.SaveChanges();
    }
    
    public void UpdateRange(List<TEntity> list)
    {
        _table.UpdateRange(list);
        _context.SaveChanges();
    }

    public TEntity? Read(int id)
    {
        return _table.Find(id);
    }

    public List<TEntity> Read(Expression<Func<TEntity, bool>> filter)
    {
        return _table.Where(filter).ToList();
    }

    public List<TEntity> Read(int start, int count)
    {
        return _table.Skip(start).Take(count).ToList();
    }

    public List<TEntity> ReadAll()
    {
        return _table.ToList();
    }

    public void Delete(TEntity t)
    {
        _table.Remove(t);
        _context.SaveChanges();
    }
}