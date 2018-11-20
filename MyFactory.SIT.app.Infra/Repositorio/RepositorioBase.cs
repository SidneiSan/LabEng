using MyFactory.SIT.app.Dominio.Interface;
using MyFactory.SIT.app.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactory.SIT.app.Infra.Repositorio
{
    public class RepositorioBase<T> : IDisposable, IRepositorioBase<T> where T : class
    {
        protected SITDbContext _context;

        //private readonly IRepositorioBase<T> _repository;

        //public RepositorioBase(IRepositorioBase<T> repository)
        //{
        //    _repository = repository;
        //}
        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Include(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        public List<T> SelectAll()
        {
            return _context.Set<T>().ToList();
        }

        public T SelectbyId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
