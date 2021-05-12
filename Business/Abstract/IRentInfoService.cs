using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRentInfoService
    {
        List<RentInfo> GetAll();
        RentInfo GetById(int rentid);
    }
}
