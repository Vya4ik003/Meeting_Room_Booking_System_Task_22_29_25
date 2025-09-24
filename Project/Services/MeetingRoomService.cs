using Project.Models;

namespace Project.Services
{
    public class MeetingRoomService : IMeetingRoomService
    {
        private IRoomRepository _repo;

        public MeetingRoomService(IRoomRepository repo)
        {
            _repo = repo;
        }

        public void BookRoom(string name, DateTime dateTime) //доделать
        {
            var rooms = _repo.GetAll();
            if (dateTime >= DateTime.Today && !rooms.Any(x => x.DateTime == dateTime))
            {
                rooms.Add(new MeetingRoom(name, dateTime));
            }
        }

        public bool IsFree(DateTime from, DateTime to)
        {
            var rooms = _repo.GetAll();
            return rooms.Any(x => x.DateTime >= from && x.DateTime <= to);
        }
 
        public List<MeetingRoom> ReturnMeetingRooms()
        {
            var rooms = _repo.GetAll();
            return rooms;
        }
    }
}