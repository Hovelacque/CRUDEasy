using CRUD.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CRUD.Models;

namespace CRUD.Repositories
{
    public class ProgramadorManager : IProgramadorManager, IDisposable
    {

        private CRUDContext _context;

        public ProgramadorManager(CRUDContext context)
        {
            _context = context;
        }

        public async Task Create(Programador input)
        {
            _context.Programadores.Add(input);
            _context.SaveChanges();
        }

        public async Task Update(Programador input)
        {
            _context.Entry(input).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task Delete(int id)
        {
            var prog = await _context.Programadores.FindAsync(id);
            _context.Programadores.Remove(prog);
            _context.SaveChanges();
        }

        public async Task<List<Programador>> GetAll()
        {
            return _context.Programadores.ToList();
        }

        public async Task<Programador> Get(int id)
        {
            return await _context.Programadores.FindAsync(id);
        }


        #region Disposable
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

       
        #endregion
    }
}