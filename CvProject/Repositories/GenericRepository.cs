using CvProject.Context;
using System.Linq.Expressions;

namespace CvProject.Repositories
{
    public class GenericRepository <T> where T : class,new()
    {
        CvContext _db = new CvContext();
        public List <T> List()
        {
            return _db.Set<T>().ToList();
        }

        public void TAdd(T p)
        {
            _db.Set<T>().Add(p);
             _db.SaveChanges();
        }

        public void TDelete(T p)
        {
            _db.Set<T>().Remove(p);
            _db.SaveChanges();
        }

        public T TGet(int id)
        {
            return _db.Set<T>().Find(id);
        }
        public void TUpdate(T p)
        {
            _db.SaveChanges();
        }
        public T Find(Expression<Func<T,bool>> where)
        {
            return _db.Set<T>().FirstOrDefault(where);
        }
    }
}
