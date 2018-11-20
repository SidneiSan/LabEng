using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactory.SIT.app.Dominio.Interface
{
    public interface IRepositorioBase<T> where T : class
    {
        void Include(T obj);
        T SelectbyID(int id);
        void Delete(T obj);
        void Update(T obj);
        List<T> SelectAll();
        void Dispose();

    }
}
