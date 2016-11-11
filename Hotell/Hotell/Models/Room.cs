using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotell.Models
{
    public class Room
    {
        public int RoomID { get; set; }

        public string RoomName { get; set; }

        public string RoomStatus { get; set; }

        public int Price { get; set; }

    }
}