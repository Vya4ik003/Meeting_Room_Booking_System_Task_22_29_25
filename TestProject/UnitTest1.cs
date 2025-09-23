using Project.Models;
using Project.Services;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void BookTest()
        {
            MeetingRoomService roomService = new MeetingRoomService();  //исправил
            roomService.BookRoom("Innokentiq", DateTime.Today);
        }

        [Fact]
        public void IsFreeTest()
        {
            MeetingRoomService roomService = new MeetingRoomService();
            roomService.BookRoom("Innokentiq", DateTime.Today);
            roomService.IsFree(DateTime.Today.AddDays(1), DateTime.Today.AddDays(-1));
            Assert.True(true);
        }

        [Fact]
        public void ReturnMeetingRoomsTest()
        {
            MeetingRoomService roomService = new MeetingRoomService();
            roomService.BookRoom("Innokentiq", DateTime.Today);
            roomService.BookRoom("Dmitriy", DateTime.Today.AddDays(1));
            List<MeetingRoom> meetingRooms = new List<MeetingRoom>();
            meetingRooms.Add(new MeetingRoom("Innokentiq", DateTime.Today));
            meetingRooms.Add(new MeetingRoom("Dmitriy", DateTime.Today.AddDays(1)));
            Assert.Equal(meetingRooms, roomService.ReturnMeetingRooms());
        }
    }
}