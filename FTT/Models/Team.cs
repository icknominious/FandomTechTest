using System;
using System.Collections.Generic;
using System.Text;

namespace FTT.Models
{
    public class Team
    {
        public string Name { get; set; }
        public string Image { get; set; }

        private IList<Player> roster;      
        internal IList<Player> Roster { get => roster; set => roster = value; }
    }
}
