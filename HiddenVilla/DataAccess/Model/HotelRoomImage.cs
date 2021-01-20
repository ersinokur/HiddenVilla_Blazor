using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class HotelRoomImage
    {
        public int ID { get; set; }
        public int RoomId { get; set; }
        public string RoomImageUrl { get; set; }
        [ForeignKey("RoomId")]
        public virtual HotelRoom HotelRoom { get; set; }

    }
}
