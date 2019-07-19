using FTT.Data;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
                PlayerCollection.ItemsSource = PlayerData.PlayerList.Where(x => x.Team == teamName);
            }
        }
        public PlayerPage()
        {
            InitializeComponent();
        }

        private void EditButtonClicked(object sender, System.EventArgs e)
        {
        }

        private void RemoveButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            PlayerData.PlayerList.FirstOrDefault(x => x.Name == button.CommandParameter.ToString()).Team = "Free Agents";
            PlayerCollection.ItemsSource = PlayerData.PlayerList.Where(x => x.Team == teamName);
        }
    }
}