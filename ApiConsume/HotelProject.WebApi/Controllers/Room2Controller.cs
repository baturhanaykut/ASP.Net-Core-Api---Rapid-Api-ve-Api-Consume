using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _romService;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService romService, IMapper mapper)
        {
            _romService = romService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _romService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Room>(roomAddDto);
            _romService.TInsert(values);
           
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Room>(updateRoomDto);
            
            _romService.TUpdate(values);

            return Ok("Başarıyla Güncellendi");
        }
    }
}
