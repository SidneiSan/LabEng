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
        protected SITDbContext db = new SITDbContext();

        public void Delete(T obj)
        {
            db.Set<T>().Remove(obj);
            db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Include(T obj)
        {
            db.Set<T>().Add(obj);
            db.SaveChanges();
        }

        public List<T> SelectAll()
        {
            return db.Set<T>().ToList();
        }

        public T SelectbyID(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Update(T obj)
        {
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
