using FTT.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FTT.Models;

namespace FTT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("Team", "team")]
    public partial class PlayerPage : ContentPage
    {
        public string teamName;
        public string Team
        {
            set
            {
                teamName = Uri.UnescapeDataString(value);
                PlayerCollection.ItemsSource = PlayerData.PlayerList.Where(x => x.Team == teamName);                                    //Collection view is bound to players whose team matches previously selected team.
            }
        }
        public PlayerPage()
        {
            InitializeComponent();
        }

        private void RemoveButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            if (teamName != "Free Agents")                                                                                      
                PlayerData.PlayerList.FirstOrDefault(x => x.Name == button.CommandParameter.ToString()).Team = "Free Agents";           //Remove player from team and send him to Free Agents.
            else
                PlayerData.PlayerList.Remove(PlayerData.PlayerList.FirstOrDefault(x => x.Name == button.CommandParameter.ToString()));  //If player is already on the Free Agent list, remove from the player pool.

            PlayerCollection.ItemsSource = PlayerData.PlayerList.Where(x => x.Team == teamName);                                        //Reset view to updated player list.
        }

        private void TeamPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;
            Player player = (Player)picker.BindingContext;
            PlayerData.PlayerList.FirstOrDefault(x => x.Name == player.Name).Team = picker.SelectedItem.ToString();                     //Player's team is changed to new team.
            PlayerCollection.ItemsSource = PlayerData.PlayerList.Where(x => x.Team == teamName);                                        //Reset view to updated player list. Player with changed team is no longer visible.
        }
    }
}