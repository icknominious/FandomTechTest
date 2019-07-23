using System.Collections.ObjectModel;
using FTT.Models;

//Player dataset used in lieu of permanent database
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
                Name = "Julian Gressel",
                Team = "Atlanta United FC",
                Goals = 4,
                Assists = 5,
                GamesPlayed = 21,
                GamesStarted = 19,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Gressel_Julian-lo.png?5N8fLWU2SDyiqyED1Pa8rLa8pUVOMrQe&itok=1tfTAZV6"
            });

            PlayerList.Add(new Player
            { 
                Name = "Jeff Larentowicz",
                Team = "Atlanta United FC",
                Goals = 0,
                Assists = 1,
                GamesPlayed = 19,
                GamesStarted = 10,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Larentowicz_Jeff-lo.png?F6j_jR6JT_J5vkcVncLTUZ4cgqWr8705&itok=O51zdezj"
            });

            PlayerList.Add(new Player
            {
                Name = "Josef Martinez",
                Team = "Atlanta United FC",
                Goals = 15,
                Assists = 2,
                GamesPlayed = 18,
                GamesStarted = 18,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Martinez_Josef-lo.png?4vbYzOFb6AZUDrgZJm9KQAFUouKlUqo1&itok=IBipIMwU"
            });

            PlayerList.Add(new Player
            {
                Name = "Pity Martinez",
                Team = "Atlanta United FC",
                Goals = 2,
                Assists = 5,
                GamesPlayed = 20,
                GamesStarted = 20,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Martinez_Gonzalo-lo.png?TfR3cYwZc6IPiv0JH37J.4s1C1xChqez&itok=i6NL7Rrt"
            });

            PlayerList.Add(new Player
            {
                Name = "Darlington Nagbe",
                Team = "Atlanta United FC",
                Goals = 1,
                Assists = 1,
                GamesPlayed = 17,
                GamesStarted = 12,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Nagbe_Darlington-lo.png?W1q36drKDPtORpKUvMMEnJ5MmWhfSjwc&itok=rMkh7KXa"
            });

            PlayerList.Add(new Player
            {
                Name = "Will Trapp",
                Team = "Colombus Crew",
                Goals = 0,
                Assists = 1,
                GamesPlayed = 19,
                GamesStarted = 19,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Trapp_Wil-1-lo.png?P4rp5aZiyInfOCscp93qVPQh9xFKW95x&itok=RfHv3PvF"
            });

            PlayerList.Add(new Player
            {
                Name = "Pedro Santos",
                Team = "Colombus Crew",
                Goals = 5,
                Assists = 2,
                GamesPlayed = 20,
                GamesStarted = 18,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Santos_Pedro-1-lo.png?4hnkWyQH5hhikio67ePZaFqdj2NYwuMe&itok=4QfNtv5k"
            });

            PlayerList.Add(new Player
            {
                Name = "Gyasi Zardes",
                Team = "Colombus Crew",
                Goals = 7,
                Assists = 1,
                GamesPlayed = 17,
                GamesStarted = 17,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Zardes_Gyasi-1-lo.png?An9VSfoHx7JbTseyGctjKIt8zgxcdqKx&itok=ydeRUGvx"
            });

            PlayerList.Add(new Player
            {
                Name = "Lucian Acosta",
                Team = "DC United",
                Goals = 5,
                Assists = 2,
                GamesPlayed = 20,
                GamesStarted = 18,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/LucianoAcosta-lo.png?.C.S7xnzYVeDJI772w8Tj7QRVEbp83bo&itok=EYFq0UsJ"
            });

            PlayerList.Add(new Player
            {
                Name = "Paul Arriola",
                Team = "DC United",
                Goals = 3,
                Assists = 1,
                GamesPlayed = 18,
                GamesStarted = 18,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/PaulArriola-lo.png?tDR2cn2GrMjTWPVaZGECbxkkD2_8_ip9&itok=r717Qp3O"
            });

            PlayerList.Add(new Player
            {
                Name = "Wayne Rooney",
                Team = "DC United",
                Goals = 10,
                Assists = 6,
                GamesPlayed = 19,
                GamesStarted = 19,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/WayneRooney-lo.png?_cMix8kpEekr4.ql8810jzSxB3HOzqzj&itok=fJqlj4AT"
            });

            PlayerList.Add(new Player
            {
                Name = "Tomas Martinez",
                Team = "Houston Dynamo",
                Goals = 2,
                Assists = 3,
                GamesPlayed = 14,
                GamesStarted = 11,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Tomas_Martinez_1-1-lo.png?NAgM_qDU4sXOd5EFUEi2SJA7ysFmrJDl&itok=FvFNpHdu"
            });

            PlayerList.Add(new Player
            {
                Name = "Christian Ramirez",
                Team = "LAFC",
                Goals = 4,
                Assists = 2,
                GamesPlayed = 12,
                GamesStarted = 1,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Christian%20Ramirez-lo.png?iJUfvbIz6G2jZSSeCQf.T9v5wK9N.tiO&itok=siJr-2g0"
            });

            PlayerList.Add(new Player
            {
                Name = "Diego Rossi",
                Team = "LAFC",
                Goals = 11,
                Assists = 5,
                GamesPlayed = 20,
                GamesStarted = 20,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Diego%20Rossi-lo.png?V9hasFjkEU16xRYFfcRYdRtCLll30Mn4&itok=owuU1RPl"
            });

            PlayerList.Add(new Player
            {
                Name = "Carlos Vela",
                Team = "LAFC",
                Goals = 19,
                Assists = 12,
                GamesPlayed = 20,
                GamesStarted = 20,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Carlos%20Vela-lo.png?BeA.jjgGkIiPN8nXuw.orCZttWKRoUm5&itok=9rP4QQWN"
            });

            PlayerList.Add(new Player
            {
                Name = "Romain Alessandrini",
                Team = "LA Galaxy",
                Goals = 0,
                Assists = 1,
                GamesPlayed = 5,
                GamesStarted = 5,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Romain%20Alessandrini-Frontal-lo.png?fMD6d2iW1Ov7ImIH0mUqhM1abPkPD4TF&itok=9TjJdb7Z"
            });

            PlayerList.Add(new Player
            {
                Name = "Jonathan dos Dantos",
                Team = "LA Galaxy",
                Goals = 2,
                Assists = 2,
                GamesPlayed = 16,
                GamesStarted = 16,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Jonathan%20dos%20Santos-Frontal-lo.png?fZqN4tD0FzQNTs5Xm7sz50PDb4mNGOwy&itok=6GxkTO7_"
            });

            PlayerList.Add(new Player
            {
                Name = "Sebastien Lletget",
                Team = "LA Galaxy",
                Goals = 1,
                Assists = 2,
                GamesPlayed = 17,
                GamesStarted = 17,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Sebastian%20Lletget-Frontal-lo.png?WFYYu0uSzpfih6tLiqFN1WE6o8DRen.w&itok=K2scADtX"
            });

            PlayerList.Add(new Player
            {
                Name = "Zlatan Ibrahimovic",
                Team = "LA Galaxy",
                Goals = 13,
                Assists = 3,
                GamesPlayed = 15,
                GamesStarted = 14,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Zlatan%20Ibrahimovic-Frontal-lo.png?gxir85eU9a1v5l.FCd1s1i3ddNmceL1W&itok=bN-cb5nz"
            });

            PlayerList.Add(new Player
            {
                Name = "Kaku",
                Team = "NY Red Bulls",
                Goals = 13,
                Assists = 3,
                GamesPlayed = 17,
                GamesStarted = 17,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/KAKU_PORTRAIT_006-lo.png?vMMuvgyP34NJka1V_KtJr97fYq1cF3Ic&itok=S0rJW9-f"
            });

            PlayerList.Add(new Player
            {
                Name = "Nani",
                Team = "Orlando SC",
                Goals = 8,
                Assists = 7,
                GamesPlayed = 9,
                GamesStarted = 8,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Nani-lo.png?.ZMZ5qh6gWL.OS7FpYgf6HibwNVbkDX2&itok=XWCpqmwR"
            });

            PlayerList.Add(new Player
            {
                Name = "Marco Fabian",
                Team = "Philadelphia Union",
                Goals = 3,
                Assists = 0,
                GamesPlayed = 12,
                GamesStarted = 8,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Fabian_Marco_front-lo.png?Hov2np6wbA5SiiuL4MSMcoMi_wMfmiD_&itok=qetIwfpP"
            });

            PlayerList.Add(new Player
            {
                Name = "Alejandro Bedoya",
                Team = "Philadelphia Union",
                Goals = 2,
                Assists = 3,
                GamesPlayed = 22,
                GamesStarted = 22,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Bedoya_Alejandro_front-lo.png?VQpKvBzkoR1sLWR5RMzW0fBoyVLaSshk&itok=rfqcJR55"
            });

            PlayerList.Add(new Player
            {
                Name = "Brian Fernandez",
                Team = "Portland Timbers",
                Goals = 6,
                Assists = 0,
                GamesPlayed = 19,
                GamesStarted = 19,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/fernandez-lo.png?PVQi.WbDeA05vkuZTs3j1KfPq7PoxxNW&itok=UX4QvJby"
            });

            PlayerList.Add(new Player
            {
                Name = "Jordan Morris",
                Team = "Seattle Sounders",
                Goals = 4,
                Assists = 2,
                GamesPlayed = 19,
                GamesStarted = 19,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Morris_Jordan-lo.png?4UWUO6Z0f6d80EGZsutxITwLdm5VLllw&itok=8vvv3z4B"
            });

            PlayerList.Add(new Player
            {
                Name = "Victor Rodriguez",
                Team = "Seattle Sounders",
                Goals = 3,
                Assists = 2,
                GamesPlayed = 10,
                GamesStarted = 4,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Rodriguez_Victor-lo.png?EBzjVOOiVDuvFllOHg9TC_EmxVz_SFSS&itok=sTqeSq85"
            });

            PlayerList.Add(new Player
            {
                Name = "Jozy Altidore",
                Team = "Toronto FC",
                Goals = 7,
                Assists = 3,
                GamesPlayed = 11,
                GamesStarted = 8,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Jozy%20Altidore-lo.png?7poO40dbtTghZxUxRzYfwSof_LfXPUIz&itok=e7Y3DYis"
            });

            PlayerList.Add(new Player
            {
                Name = "Michael Bradley",
                Team = "Toronto FC",
                Goals = 2,
                Assists = 2,
                GamesPlayed = 14,
                GamesStarted = 14,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Michael%20Bradley-lo.png?P5u_fXgtNf0odnbwEcHZFPXhciOZZFRt&itok=n0ihLYJR"
            });

            PlayerList.Add(new Player
            {
                Name = "Jonathan Osorio",
                Team = "Toronto FC",
                Goals = 3,
                Assists = 4,
                GamesPlayed = 14,
                GamesStarted = 12,
                Image = "https://league-mp7static.mlsdigital.net/styles/image_player_headshot/s3/Jonathan%20Osorio-lo.png?y0ZMhGh6x0j3oPdwk0CcBYHc8BeGqnic&itok=XbTSWJQz"
            });



        }
    }
}
