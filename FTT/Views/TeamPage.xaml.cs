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

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string catName = (e.CurrentSelection.FirstOrDefault() as Team).Name;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"catdetails?name={catName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/domestic/cats/catdetails?name={catName}");
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
