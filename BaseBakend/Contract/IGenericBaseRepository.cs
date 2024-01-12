using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.Contract;

public interface IGenericBaseRepository<TEntity> where TEntity : class
{
    TEntity GetById(int id);
    List<TEntity> GetAll();
    bool AddItem(TEntity item);
    bool UpdateItem(TEntity item);
    bool DeleteItem(int id);
}

    