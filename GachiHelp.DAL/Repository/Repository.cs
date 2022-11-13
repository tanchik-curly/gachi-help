using System.Linq.Expressions;
using GachiHelp.DAL.Context;
using GachiHelp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GachiHelp.DAL.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    private readonly GachiContext _context;

    public Repository(GachiContext context)
    {
        _context = context;
    }

    public IEnumerable<TEntity> AllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();

        query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        return query.AsEnumerable();
    }

    public IEnumerable<TEntity> GetAll() => _context.Set<TEntity>().AsEnumerable();

    public int Count() => _context.Set<TEntity>().Count();

    public TEntity? GetSingle(int id) => _context.Set<TEntity>().SingleOrDefault(e => e.Id == id);

    public TEntity? GetSingle(Expression<Func<TEntity, bool>> predicate) => _context.Set<TEntity>().FirstOrDefault(predicate);

    public TEntity? GetSingle(Expression<Func<TEntity?, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();

        query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        return query.FirstOrDefault(predicate);
    }

    public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate) => _context.Set<TEntity>().Where(predicate);

    public IEnumerable<TEntity> FindIncluding(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();

        query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        return query.Where(predicate).AsEnumerable();
    }

    public void Add(TEntity entity) => _context.Set<TEntity>().Add(entity);

    public void Update(TEntity entity) => _context.Set<TEntity>().Update(entity);

    public void Delete(TEntity entity) => _context.Set<TEntity>().Remove(entity);

    public void DeleteWhere(Expression<Func<TEntity, bool>> predicate) => _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(predicate));

    public void Save()
    {
        _context.SaveChanges();
    }
}