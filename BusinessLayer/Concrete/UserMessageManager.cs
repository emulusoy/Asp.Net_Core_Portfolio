﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public List<UserMessage> GetList()
        {
            return _userMessageDal.GetList();
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
            return _userMessageDal.GetUserMessageWithUser();
        }

        public void TAdd(UserMessage t)
        {
            _userMessageDal.Insert(t);
        }

        public void TDelete(UserMessage t)
        {
            _userMessageDal.Delete(t);
        }

        public UserMessage TGetById(int id)
        {
            return _userMessageDal.GetById(id);
        }

        public void TUpdate(UserMessage t)
        {
            _userMessageDal.Update(t);
        }
    }
}
