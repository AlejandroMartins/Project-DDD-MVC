using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Interfaces.Respositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        void DeleteById(int id);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        void Update (TEntity obj);
        void Dispose();
    }
}
