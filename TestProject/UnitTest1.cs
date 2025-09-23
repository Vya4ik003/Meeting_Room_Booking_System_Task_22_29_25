using Project.Models;
using Project.Services;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void BookTest()
        {
            MeetingRoomService roomService = new MeetingRoomService();
            roomService.BookRoom("Innokentiq", DateTime.Today);
            Assert.Equal(new MeetingRoom("Innokentiq", DateTime.Today), roomService.meetingRooms[0]);
        }

        [Fact]
        public void IsFreeTest()
        {
            MeetingRoomService roomService = new MeetingRoomService();
            roomService.BookRoom("Innokentiq", DateTime.Today);
            bool truth = roomService.IsFree(DateTime.Today.AddDays(1), DateTime.Today.AddDays(-1));
            Assert.True(truth);
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