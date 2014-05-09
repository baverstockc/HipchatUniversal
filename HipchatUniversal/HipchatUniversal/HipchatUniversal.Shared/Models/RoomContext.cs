using System;
using System.Collections.Generic;
using System.Text;

namespace HipchatUniversal.Models
{
    public class RoomContext
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int MemberCount { get; set; }
    }
}
