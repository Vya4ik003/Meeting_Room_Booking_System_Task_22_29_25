using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [Route("api")]
    [ApiController]
    public class MeetingRoomController : ControllerBase
    {
        private IMeetingRoomService _meetingRoomService;

        public MeetingRoomController(IMeetingRoomService meetingRoomService)
        {
            _meetingRoomService = meetingRoomService;
        }

        [HttpPost("book")]
        public void BookRoom([FromBody] BookRoomRequest bookRoomRequest)
        {
            _meetingRoomService.BookRoom(bookRoomRequest.Name, bookRoomRequest.DateTime);
        }

        [HttpPost("isFree")]
        public IActionResult IsFree([FromBody] IsFreeRequest isFreeRequest)
        {
            return Ok(_meetingRoomService.IsFree(isFreeRequest.From, isFreeRequest.To));
        }

        [HttpGet("returnRooms")]
        public IActionResult ReturnMeetingRooms()
        {
            return Ok(_meetingRoomService.ReturnMeetingRooms());
        }
    }
}