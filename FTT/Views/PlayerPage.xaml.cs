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
        List<string> teamNames;
        public string Team
        {
            set
            {
                teamName = Uri.UnescapeDataString(value);
                PlayerCollection.ItemsSource = PlayerData.PlayerList.Where(x => x.Team == teamName);
            }
        }
        public PlayerPage()
        {
            InitializeComponent();
            teamNames = new List<string>();
            foreach (Team team in TeamData.TeamList)
            {
                teamNames.Add(team.Name);
            }
        }

        private void RemoveButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            PlayerData.PlayerList.FirstOrDefault(x => x.Name == button.CommandParameter.ToString()).Team = "Free Agents";
            PlayerCollection.ItemsSource = PlayerData.PlayerList.Where(x => x.Team == teamName);
        }

        private void TeamPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;
            Player player = (Player)picker.BindingContext;
            PlayerData.PlayerList.FirstOrDefault(x => x.Name == player.Name).Team = picker.SelectedItem.ToString();
            PlayerCollection.ItemsSource = PlayerData.PlayerList.Where(x => x.Team == teamName);
        }
    }
}