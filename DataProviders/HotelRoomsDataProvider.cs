using CoreLibrary.Data;
using CoreLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CoreLibrary.DataProviders
{
    public class HotelRoomsDataProvider : IHotelRoomsDataProvider
    {
        private readonly HotelDataContext _dbContext;

        public HotelRoomsDataProvider(HotelDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(IHotelRoom entity)
        {
            _dbContext.Set<IHotelRoom>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public IHotelRoom FindByRoomNumber(string roomNumber)
        {
            return _dbContext.Set<HotelRoom>().FirstOrDefault(r => r.RoomNumber == roomNumber);
        }

        public void Insert(IHotelRoom entity)
        {
            _dbContext.Set<IHotelRoom>().Add(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<IHotelRoom> List()
        {
            return _dbContext.Set<HotelRoom>().AsEnumerable();
        }

        public IEnumerable<IHotelRoom> List(Expression<Func<IHotelRoom, bool>> predicate)
        {
            return _dbContext.Set<HotelRoom>().Where(predicate);
        }

        public void Update(IHotelRoom entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.Set<HotelRoom>().Update((HotelRoom)entity);
            _dbContext.SaveChanges();
        }
    }
}
