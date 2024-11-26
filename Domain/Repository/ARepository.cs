using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;

namespace Domain.Repository;

public class ARepository<TEntity>: IRepository<TEntity> where TEntity : class
{
    protected LibraryContext Config;
    protected DbSet<TEntity> Table;

    public ARepository(LibraryContext config)
    {
        Config = config;
        Table = config.Set<TEntity>();
    }
    public TEntity Create(TEntity t)
    {
        Table.Add(t);
        Config.SaveChanges();
        return t;
    }

    public List<TEntity> CreateRange(List<TEntity> list)
    {
        Table.AddRange(list);
        Config.SaveChanges();
        return list;
    }

    public void Update(TEntity t)
    {
        Config.ChangeTracker.Clear();
        Table.Update(t);
        Config.SaveChanges();
    }

    public void UpdateRange(List<TEntity> list)
    {
        Table.UpdateRange(list);
        Config.SaveChanges();
    }

    public TEntity? Read(int id) => Table.Find(id);

    public List<TEntity> Read(Expression<Func<TEntity, bool>> filter) => Table.Where(filter).ToList();

    public List<TEntity> Read(int start, int count) => Table.Skip(start).Take(count).ToList();

    public List<TEntity> ReadAll() => Table.ToList();

    public void Delete(int id)
    {

        var entity = Table.Find(id);
        Table.Remove(entity);
        Config.SaveChanges();
    }
}