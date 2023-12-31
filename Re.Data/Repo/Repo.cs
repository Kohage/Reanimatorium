using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Re.Core.Extensions;
using Re.Core.Models;

namespace Re.Data.Repo
{
    public class Repo<T> : IRepo<T> where T : class
    {
        DataContext _context;
        DbSet<T> _dbSet;
        public Repo(DataContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> SaveAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAsync()
        {
            return await _context.Set<T>().IncludeAll().ToListAsync();
        }
        //public async Task<List<T>> GetByDate(DateTime date)
        //{
        //    return await _dbSet.Where(e => e.GetDate() == date);
        //}
        //public async Task<List<T>> GetByDoctorName(string name)
        //{
        //    return await _context.Set<T>().Where(e => e.GetType().Name == name).ToListAsync();
        //}
        //public async Task<List<T>> GetByType(Type type)
        //{
        //    return await _context.Set<T>().Where(e => e.GetType() == type).ToListAsync();
        //}
    }
}