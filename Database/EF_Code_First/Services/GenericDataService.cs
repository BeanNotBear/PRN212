using EF_Code_First.Data;
using EF_Code_First.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Code_First.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {

        private readonly ApplicationDbContextFactory _contextFactory;

        public GenericDataService(ApplicationDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using (ApplicationDbContext context = _contextFactory.CreateDbContext())
            {
                var CreatedEntity = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return CreatedEntity.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (ApplicationDbContext context = _contextFactory.CreateDbContext())
            {
                var DeletedEntity = await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
                context.Set<T>().Remove(DeletedEntity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<T> Get(int id)
        {
            using (ApplicationDbContext context = _contextFactory.CreateDbContext())
            {
                var FindedEntity = await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
                return FindedEntity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (ApplicationDbContext context = _contextFactory.CreateDbContext())
            {
                var entities = await context.Set<T>().ToListAsync();
                return entities;
            }
        }

        public async Task<T> Update(int id ,T entity)
        {
            using (ApplicationDbContext context = _contextFactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }
    }
}
