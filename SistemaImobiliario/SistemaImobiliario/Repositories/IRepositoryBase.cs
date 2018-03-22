using System.Collections.Generic;

public interface IRepositoryBase<TEntity> where TEntity : class 
    {
        TEntity Add(TEntity item);
        TEntity GetById(int id);
        IEnumerable<TEntity> Get();
        bool Update(TEntity item);
        int Count();
        void Dispose();
    }