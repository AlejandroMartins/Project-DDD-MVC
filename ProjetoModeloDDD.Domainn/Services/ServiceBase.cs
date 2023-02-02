using ProjetoModeloDDD.Domain.Interfaces.Respositories;
using ProjetoModeloDDD.Domainn.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domainn.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

   

        public void Add(TEntity obg)
        {
            _repository.Add(obg);
        }

        public void Dispose()
        {
            _repository.Dispose();   
        }

        public void Dispsoe()
        {
            _repository.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();    
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(int id)
        {
            _repository.DeleteById(id);
        }

        public void Remove(TEntity obg)
        {
            _repository.Remove(obg);
        }

        public void Update(TEntity obg)
        {
            _repository.Update(obg);
        }
    }
}
