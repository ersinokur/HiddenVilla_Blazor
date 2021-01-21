using Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelRoomImagesRepository
    {
        public Task<int> CreateHotelRoomImage(HotelRoomImageDTO image);
        public Task<int> DeleteHotelRoomImagebyId(int imageId);
        public Task<int> DeleteHotelRoomImagebyRoomId(int roomId);
        public Task<int> DeleteHotelRoomImagebyImageUrl(string imgURL);
        public Task<IEnumerable<HotelRoomImageDTO>> GetHotelRoomImages(int roomId);

    }
}
