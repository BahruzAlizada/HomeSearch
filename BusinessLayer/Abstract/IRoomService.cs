using EntityLayer.Concrete;
using System;


namespace BusinessLayer.Abstract
{
    public interface IRoomService
    {
        Task<List<Room>> GetAll();
        Room GetRoom(int? id);
        void Add(Room room);
        void Update(Room room);
        void Delete(int id);
    }
}
