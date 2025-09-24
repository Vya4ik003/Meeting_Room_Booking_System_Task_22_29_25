using Moq;
using Project.Models;
using Project.Services;

namespace TestProject
{
    public class MeetingRoomServiceTests
    {
        [Fact]
        public void BookTest_12345()
        {
            var mockRepo = new Mock<IRoomRepository>();
            var mockServ = new Mock<IMeetingRoomService>();
            var test = new TestService(mockRepo.Object, mockServ.Object);
        }

        [Fact]
        public void BookTest_123()
        {
            var a = 0;
            var mockRepo = new Mock<IRoomRepository>();
            mockRepo.Setup(_ => _.GetAll())
                .Callback(() => a = 5)
                .Returns(new List<MeetingRoom>()
                {
                    new MeetingRoom("abc1", DateTime.Now.AddHours(10)),
                    new MeetingRoom("abc2", DateTime.Now.AddDays(2)),
                    new MeetingRoom("abc3", DateTime.Now),
                });

            /*
             * A -> B -> C -> D
             * A -> B
             * B -> C
             * C -> D
             */

            var list = mockRepo.Object.GetAll();
            Assert.Equal(3, list.Count);
            Assert.Equal(5, a);
        }

        [Fact]
        public void BookTest_1()
        {
            var mockRepo = new Mock<IRoomRepository>();
            mockRepo.Setup(_ => _.GetByName(""))
                .Throws(new Exception("Name is empty"));

            mockRepo.Object.GetByName("");
            Assert.Throws<Exception>(() => mockRepo.Object.GetByName(""));
        }

        [Fact]
        public void BookTest()
        {
            var mockRepo = new Mock<IRoomRepository>();
            mockRepo.Setup(_ => _.GetAll())
                .Returns(new List<MeetingRoom>()
                {
                    new MeetingRoom("abc1", DateTime.Now.AddHours(10)),
                    new MeetingRoom("abc2", DateTime.Now.AddDays(2)),
                    new MeetingRoom("abc3", DateTime.Now),
                });
            // A -> B -> C -> D
            MeetingRoomService roomService = new MeetingRoomService(mockRepo.Object);
            roomService.BookRoom("Innokentiq", DateTime.Today);
            //Assert.Equal(new MeetingRoom("Innokentiq", DateTime.Today), roomService.meetingRooms[0]);
        }

        [Fact]
        public void IsFreeTest()
        {
            //MeetingRoomService roomService = new MeetingRoomService();
            //roomService.BookRoom("Innokentiq", DateTime.Today);
            //bool truth = roomService.IsFree(DateTime.Today.AddDays(1), DateTime.Today.AddDays(-1));
            //Assert.True(truth);
        }

        [Fact]
        public void ReturnMeetingRoomsTest()
        {
            //MeetingRoomService roomService = new MeetingRoomService();
            //roomService.BookRoom("Innokentiq", DateTime.Today);
            //roomService.BookRoom("Dmitriy", DateTime.Today.AddDays(1));
            //List<MeetingRoom> meetingRooms = new List<MeetingRoom>();
            //meetingRooms.Add(new MeetingRoom("Innokentiq", DateTime.Today));
            //meetingRooms.Add(new MeetingRoom("Dmitriy", DateTime.Today.AddDays(1)));
            //Assert.Equal(meetingRooms, roomService.ReturnMeetingRooms());
        }
    }
}