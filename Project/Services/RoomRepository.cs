using Project.Models;

namespace Project.Services
{
    public class RoomRepository : IRoomRepository
    {
        private List<MeetingRoom> _meetingRooms { get; set; } = new List<MeetingRoom>();

        public RoomRepository(IMyTestService serv)
        {

        }

        public List<MeetingRoom> GetAll()
        {
            // _meetingRooms = serv.FunFunc();
            return _meetingRooms;
        }

        public MeetingRoom GetByName(string name)
        {
            return _meetingRooms.First(_ => _.Name == name);
        }

        public void RemoveByName(string name)
        {
            _meetingRooms.RemoveAll(_ => _.Name == name);
        }
    }
}
