using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBusiness
{
    public class GenericManager<T>
    {

        HotelDal.DataBaseManager<T> _db;
        public GenericManager()
        {
            _db = new HotelDal.DataBaseManager<T>();
        }
        public bool Insert(T entity)
        {

            return _db.Insert(entity);

        }

        public bool Update(T entity)
        {

            return _db.Update(entity);

        }

        public bool Delete(T entity)
        {

            return _db.Delete(entity);


        }
    }
}
