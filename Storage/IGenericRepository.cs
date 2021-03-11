using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Storage
{
    interface IGenericRepository
    {
        void Save(IEntity entity);
        List<IEntity> GetAll(IEntity e);
        List<IEntity> GetAllWhere(IEntity e);

        int GetNewId(IEntity e);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();

        void Delete(IEntity e);
        void Update(IEntity e);
    }
}
