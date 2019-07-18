using FTT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FTT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("Team", "team")]
    public partial class PlayerPage : ContentPage
    {
        public string Team
        {
            set
            {
                PlayerCollection.ItemsSource = PlayerData.PlayerList.Where(x => x.Team == Uri.UnescapeDataString(value));
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
        }
    }
}