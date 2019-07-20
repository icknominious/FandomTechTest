using System.Collections.Generic;
using System.Collections.ObjectModel;
using FTT.Models;

//Team dataset used in lieu of permanent database
namespace FTT.Data
{
    public static class TeamData
    {
        public static ObservableCollection<Team> TeamList { get; set; }
        public static List<string> teamNames;

        static TeamData()
        {
            TeamList = new ObservableCollection<Team>();

            TeamList.Add(new Team
            {
                Name = "Atlanta United FC",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/b/bb/Atlanta_MLS.svg/1920px-Atlanta_MLS.svg.png"
            });
            TeamList.Add(new Team
            {
                Name = "Colombus Crew",
                Image = "https://supercote.ro/images/upload/logos/columbus.png"
            });
            TeamList.Add(new Team
            {
                Name = "DC United",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/3/32/D.C._United_logo_%282016%29.svg/180px-D.C._United_logo_%282016%29.svg.png"
            });
            TeamList.Add(new Team
            {
                Name = "Houston Dynamo",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0c/Houston_Dynamo_logo.svg/1200px-Houston_Dynamo_logo.svg.png"
            });
            TeamList.Add(new Team
            {
                Name = "LAFC",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/8/86/Los_Angeles_Football_Club.svg/1200px-Los_Angeles_Football_Club.svg.png"
            });
            TeamList.Add(new Team
            {
                Name = "LA Galaxy",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/7/70/Los_Angeles_Galaxy_logo.svg/1200px-Los_Angeles_Galaxy_logo.svg.png"
            });
            TeamList.Add(new Team
            {
                Name = "NY Red Bulls",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/5/51/New_York_Red_Bulls_logo.svg/1200px-New_York_Red_Bulls_logo.svg.png"
            });
            TeamList.Add(new Team
            {
                Name = "Orlando SC",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/6/6a/Orlando_City_2014.svg/1200px-Orlando_City_2014.svg.png"
            });
            TeamList.Add(new Team
            {
                Name = "Philadelphia Union",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/4/46/Philadelphia_Union_2018_logo.svg/1200px-Philadelphia_Union_2018_logo.svg.png"
            });
            TeamList.Add(new Team
            {
                Name = "Portland Timbers",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/3/35/Portland_Timbers_logo.svg/1200px-Portland_Timbers_logo.svg.png"
            });
            TeamList.Add(new Team
            {
                Name = "Seattle Sounders",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/2/27/Seattle_Sounders_FC.svg/1200px-Seattle_Sounders_FC.svg.png"
            });
            TeamList.Add(new Team
            {
                Name = "Toronto FC",
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/7/7c/Toronto_FC_Logo.svg/2560px-Toronto_FC_Logo.svg.png"
            });
            TeamList.Add(new Team
            {
                Name = "Free Agents",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/MLS_crest_logo_RGB_gradient.svg/1200px-MLS_crest_logo_RGB_gradient.svg.png"
            });

            teamNames = new List<string>();
            foreach (Team team in TeamList)
            {
                teamNames.Add(team.Name);
            }
        }
    }
}
