using System;

namespace HotelDal
{
    public class DataBaseManager<T>
    {
        public DataBaseManager()
        {

        }
        public bool Insert(T entity)
        {
            if (entity != null) return true;
            return false;
        }

        public bool Update(T entity)
        {
            if (entity != null) return true;
            return false;
        }
        public bool Delete(T entity)
        {
            if (entity != null) return true;
            return false;
        }
    }
}
