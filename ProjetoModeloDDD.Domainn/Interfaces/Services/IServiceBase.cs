using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domainn.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obg);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obg);
        void Remove(TEntity obg);
        void Dispsoe();

    }
}
