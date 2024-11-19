using System.Linq.Expressions;

namespace Domain.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    TEntity Create(TEntity t);
    List<TEntity> CreateRange(List<TEntity> list);
    void Update(TEntity t);
    void UpdateRange(List<TEntity> list);
    TEntity? Read(int id);
    List<TEntity> Read(Expression<Func<TEntity, bool>> filter); //In filter wird eine Lambda Expression übergeben, TEntity ist der Eingangsparameter, bool der Ausgangsparameter. In der Liste werden jetzt alle Elemente gespeichert. Beispiel: Alle Bücher mit Author "blabla", werden alle Bücher mit dem Author in der Liste gespeichert
    List<TEntity> Read(int start, int count);
    List<TEntity> ReadAll();
}