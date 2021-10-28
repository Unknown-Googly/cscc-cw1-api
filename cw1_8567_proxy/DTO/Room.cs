using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw1_8567_proxy.DTO
{
    public class Room
    {
        [Key]
        public int? RoomId { get; set; }
        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public bool IsAvailable { get; set; }
        public decimal Price { get; set; }
        public string Brief { get; set; }
    }
}
