using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentInfoManager : IRentInfoService
    {
        IRentInfoDal _rentInfoDal;

        public RentInfoManager(IRentInfoDal rentInfoDal)
        {
            _rentInfoDal = rentInfoDal;
        }

        public List<RentInfo> GetAll()
        {
            return _rentInfoDal.GetAll();
        }

        public RentInfo GetById(int rentid)
        {
            return _rentInfoDal.Get(r => r.Id == rentid);
        }
    }
}
