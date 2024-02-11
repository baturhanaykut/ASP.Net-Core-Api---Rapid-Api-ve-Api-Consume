using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;
        private readonly IRoomService _roomService;

        public DashboardWidgetController(IStaffService staffService, IBookingService bookingService, IAppUserService appUserService, IRoomService roomService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _appUserService = appUserService;
            _roomService = roomService;
        }

        [HttpGet("StaffCount")]
        public IActionResult StaffCount()
        {
            return Ok(_staffService.TGetStaffCount());
        }

        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            return Ok(_bookingService.TGetBookingCount());
        }

        [HttpGet("UsersCount")]
        public IActionResult UsersCount()
        {
            return Ok(_appUserService.TGetUserCount());
        }

        [HttpGet("RoomsCount")]
        public IActionResult RoomsCount()
        {
            return Ok(_roomService.TGetRoomCount());
        }
    }
}
