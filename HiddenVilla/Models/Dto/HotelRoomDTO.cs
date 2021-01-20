﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto
{
    public class HotelRoomDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter room name") ]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Occupancy ")]
        public int Occupancy { get; set; }
        [Range(1, 3000, ErrorMessage = "Regular rate must be betseen 1 and 3000")]
        [Required]
        public double RegularRate { get; set; }
        public string Details { get; set; }
        public string SqFt { get; set; }
    }
}
