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
    public class SendMessageManager:IMessageService
    {
        IMessageDal _messageDal;

        public SendMessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetList()
        {
            return _messageDal.GetList();
        }

        public void TAdd(Message t)
        {
           _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
