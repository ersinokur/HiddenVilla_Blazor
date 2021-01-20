using AutoMapper;
using DataAccess.Model;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelRoomDTO, HotelRoom>();
            CreateMap<HotelRoom, HotelRoomDTO>();

            //CreateMap<HotelRoomImageDTO, HotelRoomImage>();
            CreateMap<HotelRoomImage, HotelRoomImageDTO>().ReverseMap();

        }
    }
}
