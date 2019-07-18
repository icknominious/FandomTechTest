using System.Collections.ObjectModel;
using FTT.Models;

namespace FTT.Data
{
    public static class PlayerData
    {
        public static ObservableCollection<Player> PlayerList { get; set; }

        static PlayerData()
        {
            PlayerList = new ObservableCollection<Player>();

            PlayerList.Add(new Player
            {
                Name = "Guy",
                Team = "LA Galaxy",
                Goals = 1,
                Assists = 2
            });

            PlayerList.Add(new Player
            {
                Name = "Other Guy",
                Team = "LA Galaxy",
                Goals = 1,
                Assists = 2
            });


        }
    }
}
