using CoreLibrary.Data;
using CoreLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.DataProviders
{
    public class HotelRoomsDataProvider : IEntityDataProvider<HotelRoom>
    {
        private readonly HotelDataContext _dbContext;

        public HotelRoomsDataProvider(HotelDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(HotelRoom entity)
        {
            _dbContext.Set<HotelRoom>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Insert(HotelRoom entity)
        {
            _dbContext.Set<HotelRoom>().Add(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<HotelRoom> List()
        {
            return _dbContext.Set<HotelRoom>().AsEnumerable();
        }

        public IEnumerable<HotelRoom> List(Expression<Func<HotelRoom, bool>> predicate)
        {
            return _dbContext.Set<HotelRoom>().Where(predicate);
        }

        public void Update(HotelRoom entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.Set<HotelRoom>().Update(entity);          
            _dbContext.SaveChanges();
        }
    }
}
