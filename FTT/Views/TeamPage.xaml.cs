using System;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;
using FTT.Models;
using FTT.Data;

namespace FTT.Views
{
    public partial class TeamPage : ContentPage
    {
        public TeamPage()
        {
            InitializeComponent();
        }
        async private void ViewButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            string team = button.CommandParameter.ToString();
            await Shell.Current.GoToAsync($"players?team={team}");
        }

        private void RemoveButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            TeamData.TeamList.Remove(TeamData.TeamList.FirstOrDefault(x => x.Name == button.CommandParameter.ToString()));
        }

    }
}
