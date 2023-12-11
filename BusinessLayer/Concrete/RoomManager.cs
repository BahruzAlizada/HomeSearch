using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;

namespace BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal roomDal;
        public RoomManager(IRoomDal roomDal)
        {
            this.roomDal = roomDal;
        }


        public void Add(Room room)
        {
            roomDal.Add(room);
        }

        public void Delete(int id)
        {
            Room room = roomDal.Get(x => x.Id == id);
            roomDal.Delete(room);
        }

        public async Task<List<Room>> GetAll()
        {
            return await roomDal.GetAllAsync();
        }

        public Room GetRoom(int? id)
        {
            return roomDal.Get(x=>x.Id== id);
        }

        public void Update(Room room)
        {
            roomDal.Update(room);
        }
    }
}
