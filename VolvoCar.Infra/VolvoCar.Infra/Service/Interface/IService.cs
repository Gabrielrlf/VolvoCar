using System.Linq;

namespace VolvoCar.Infra.Service.Interface
{
    interface IService<T> where T : class
    {
        IQueryable<T> List();
        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);
        T FindById(int? id);

    }
}
