using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class IToManager:IToService
    {
        IToDal _toDal;

        public IToManager(IToDal toDal)
        {
            _toDal = toDal;
        }

        public List<To> GetList()
        {
            return _toDal.GetList();
        }

        public void TAdd(To t)
        {
            _toDal.Insert(t);
        }

        public void TDelete(To t)
        {
            _toDal.Delete(t);   
        }

        public To TGetById(int id)
        {
            return _toDal.GetById(id);
        }

        public List<To> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(To t)
        {
           _toDal.Update(t);
        }
    }
}
