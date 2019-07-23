using System;
using System.Collections.Generic;
using System.Text;

//Player base class
namespace FTT.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesStarted { get; set; }
        public string Image { get; set; }
    }
}
