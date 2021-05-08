using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfVehicleDal : IVehicleDal
    {
        public void Add(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public Vehicle Get(Expression<Func<Vehicle, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetAll(Expression<Func<Vehicle, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Vehicle entity)
        {
            throw new NotImplementedException();
        }
    }
}
