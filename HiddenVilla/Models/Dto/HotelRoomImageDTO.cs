﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto
{
    public class HotelRoomImageDTO
    {
        public int ID { get; set; }
        public int RoomId { get; set; }
        public string RoomImageUrl { get; set; }
    }
}
