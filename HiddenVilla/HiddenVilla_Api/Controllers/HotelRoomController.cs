using Business.Repository.IRepository;
using Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Api.Controllers
{
    [Route("api/[controller]")]
    public class HotelRoomController : Controller
    {
        private readonly IHotelRoomRepository _hotelRoomRepository;

        public HotelRoomController(IHotelRoomRepository hotelRoomRepository)
        {
            _hotelRoomRepository = hotelRoomRepository;
        }

        [Authorize(Roles = SD.Role_Admin)]
        [HttpGet]
        public async Task<IActionResult> GetHotelRooms()
        {
            var allRooms = await _hotelRoomRepository.GetALLHotelRooms();
            return Ok(allRooms);
        }
        [HttpGet("{roomId}")]
        public async Task<IActionResult> GetHotelRoom(int? roomId)
        {
            if (roomId == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid room id",
                    StatucCode = StatusCodes.Status400BadRequest
                });
            }

            var roomDetails = await _hotelRoomRepository.GetHotelRoom(roomId.Value);
            if (roomDetails == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "room is not found",
                    StatucCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(roomDetails);
        }
        
    }
}
