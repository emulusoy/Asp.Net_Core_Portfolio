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
    public class WriterMessageManager:IWriterMessageService
    {
        IWriterMessageDal _writerMessage;

        public WriterMessageManager(IWriterMessageDal writerMessage)
        {
            _writerMessage = writerMessage;
        }

        public List<WriterMessage> GetList()
        {
            return _writerMessage.GetList();    
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
             return _writerMessage.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSendMessage(string p)
        {
            return _writerMessage.GetByFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            _writerMessage.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writerMessage.Delete(t);
        }

        public WriterMessage TGetById(int id)
        {
           return _writerMessage.GetById(id);
        }

        public List<WriterMessage> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            _writerMessage.Update(t);
        }
    }
}
