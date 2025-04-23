using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain.Common;
using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly HrDatabaseContext _context; // ADD TO NOTION we can use this _context in the repositories that enhirits from this reposiroty

    public GenericRepository(HrDatabaseContext context)
    {
        this._context = context;
    }

    public async Task<IReadOnlyList<T>> GetAsync()
    {
        return await _context
            .Set<T>()
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context
            .Set<T>()
            .AsNoTracking() // ADD TO NOTION Comment about the AsNoTracking (You can get more performance by disabling the AsNoTracking)
            .FirstOrDefaultAsync(q => q.Id == id);
    }

    public async Task CreateAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        //_context.Update(entity); ADD TO NOTION
        await _context.SaveChangesAsync();
    }
}
