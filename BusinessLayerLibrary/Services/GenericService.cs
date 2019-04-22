using AutoMapper;
using RepositoryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services
{
    public abstract class GenericService<T, D> : IGenericService<D>
        where T : class, new()
        where D : class, new()
    {
        IGenericRepository<T> repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<T> repository)
        {
            this.repository = repository;
            this._mapper = GetMapper();
        }

        abstract protected IMapper GetMapper();

        public D Add(D obj)
        {
            T elem = _mapper.Map<T>(obj);
            repository.AddOrUpdate(elem);
            repository.Save();
            return _mapper.Map<D>(elem);
        }

        public D Delete(int id)
        {
            T elem = repository.Get(id);
            repository.Delete(elem);
            repository.Save();
            return _mapper.Map<D>(elem);
        }

        public IEnumerable<D> FindBy(Expression<Func<D, bool>> predicate)
        {
            try
            {
                var predicateElem = _mapper.Map<Expression<Func<T, bool>>>(predicate);
                return repository.FindBy(predicateElem)
                    .Select(c => _mapper.Map<D>(c));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public D Get(int id)
        {
            T elem = repository.Get(id);
            return _mapper.Map<D>(elem);
        }

        public IEnumerable<D> GetAll()
        {
            return repository.GetAll().Select(elem => _mapper.Map<D>(elem));
        }

        public void Save()
        {
            repository.Save();
        }

        public D Update(D obj)
        {
            T elem = _mapper.Map<T>(obj);
            repository.AddOrUpdate(elem);
            repository.Save();
            return _mapper.Map<D>(elem);
        }
    }
}
