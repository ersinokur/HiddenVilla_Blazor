using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public HotelRoomRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoomDTO)
        {
            HotelRoom hotelRoom = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelRoomDTO);
            hotelRoom.CreatedDate = DateTime.Now;
            hotelRoom.CreatedBy = "";

            var addHotelRoom = await _db.HotelRooms.AddAsync(hotelRoom);
            await _db.SaveChangesAsync();

            return _mapper.Map<HotelRoom, HotelRoomDTO>(addHotelRoom.Entity);
        }

        public async Task<int> DeleteHotelRoom(int roomId)
        {
            var roomDetails = await _db.HotelRooms.FindAsync(roomId);
            if (roomDetails != null)
            {
                _db.HotelRooms.Remove(roomDetails);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetALLHotelRooms()
        {
            try
            {
                IEnumerable<HotelRoomDTO> hotelRoomDTOs =
                    _mapper.Map<IEnumerable<HotelRoom>, IEnumerable<HotelRoomDTO>>(_db.HotelRooms);

                return hotelRoomDTOs;
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }

        public async Task<HotelRoomDTO> GetHotelRoom(int roomId)
        {
            try
            {
                HotelRoomDTO hotelRoom = _mapper.Map<HotelRoom, HotelRoomDTO>(
                    await _db.HotelRooms.FirstOrDefaultAsync(x => x.Id == roomId)
                    );

                return hotelRoom;
            }
            catch (Exception ex)
            {

                return null; ;
            }
        }
        //if unique returns null ekse returns the room object 
        public async Task<HotelRoomDTO> IsRoomUnique(string name, int roomId = 0)
        {

            try
            {
                if (roomId == 0)
                {
                    HotelRoomDTO hotelRoom = _mapper.Map<HotelRoom, HotelRoomDTO>(
                        await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name == name.ToLower())
                        );

                    return hotelRoom;
                }
                else
                {
                    HotelRoomDTO hotelRoom = _mapper.Map<HotelRoom, HotelRoomDTO>(
                       await _db.HotelRooms.FirstOrDefaultAsync(x => x.Name == name.ToLower() && x.Id != roomId)
                       );

                    return hotelRoom;
                }
            }
            catch (Exception ex)
            {

                return null; ;
            }
        }

        public async Task<HotelRoomDTO> UpdateHotelRoom(int id, HotelRoomDTO hotelRoomDTO)
        {
            try
            {
                if (id == hotelRoomDTO.Id)
                {
                    //valid
                    HotelRoom roomDetails = await _db.HotelRooms.FindAsync(id);
                    HotelRoom room = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelRoomDTO, roomDetails);
                    room.UpdatedTime = DateTime.Now;
                    room.UpdatedBy = "";

                    var updatedRoom = _db.HotelRooms.Update(room);
                    await _db.SaveChangesAsync();

                    return _mapper.Map<HotelRoom, HotelRoomDTO>(updatedRoom.Entity);
                }
                else
                {
                    //invalid
                    return null;
                }
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
