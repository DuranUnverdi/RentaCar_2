using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class RentInfo:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }//aracı kiralayan çalışan
        public int CityId { get; set; }//aracın alınacağı bayi ya da havaalanı 
    }
}
