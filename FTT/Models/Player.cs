using System;
using System.Collections.Generic;
using System.Text;

namespace FTT.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public string Image { get; set; }
    }
}
