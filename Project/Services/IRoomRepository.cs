using Project.Models;

namespace Project.Services
{
    public interface IRoomRepository
    {
        List<MeetingRoom> GetAll();
        MeetingRoom GetByName(string name);
        void RemoveByName(string name);
    }
}