using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Acr.UserDialogs;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FTT.Models;
using FTT.Data;

namespace FTT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPlayer : ContentPage
    {
        
        public NewPlayer()
        {
            InitializeComponent();
            teamPicker.ItemsSource = TeamData.teamNames;
        }

        private void CreateButton_Clicked(object sender, EventArgs e)
        {
            if (nameEntry.Text == null || Picture.Source == null || teamPicker.SelectedItem == null)    //If create player data is missing, ignore button click. Prompt user to add more info.    
            {
                ToastConfig errorToastConfig = new ToastConfig("New Player form incomplete");
                errorToastConfig.SetDuration(1000);
                errorToastConfig.SetBackgroundColor(Color.DimGray);
                UserDialogs.Instance.Toast(errorToastConfig);
                return;
            }

            Player newPlayer = new Player();                                                            //Otherwise, create a new player instance and match attributes to those entered in form.
            newPlayer.Name = nameEntry.Text;
            newPlayer.Image = Picture.Source.ToString().Replace("Uri: ", "");
            Int32.TryParse(goalsEntry.Text, out int a);
            Int32.TryParse(assistsEntry.Text, out int b);
            Int32.TryParse(gamesPlayedEntry.Text, out int c);
            Int32.TryParse(gamesStartedEntry.Text, out int d);
            newPlayer.Goals = a;
            newPlayer.Assists = b;
            newPlayer.GamesStarted = c;
            newPlayer.GamesPlayed = d;
            newPlayer.Team = teamPicker.SelectedItem.ToString();

            PlayerData.PlayerList.Add(newPlayer);                                                       //Prompt user that a player was created.
            ToastConfig toastConfig = new ToastConfig("Player created");
            toastConfig.SetDuration(1000);
            toastConfig.SetBackgroundColor(Color.DimGray);
            UserDialogs.Instance.Toast(toastConfig);
            
        }

        private void PictureButton_Clicked(object sender, EventArgs e)
        {
            PromptConfig promptConfig = new PromptConfig();
            Action<PromptResult> promptAction = promptResult =>                                         //Action taken when user hits confirm.
            {
                Picture.Source = promptResult.Text;
            };
            promptConfig.Message = "Enter picture URL";                                                 //Promt user to enter a picture url.
            promptConfig.Placeholder = Picture.Source.ToString().Replace("Uri: ", "");
            promptConfig.OkText = "Confirm";
            promptConfig.CancelText = "Cancel";
            promptConfig.OnAction = promptAction;
            UserDialogs.Instance.Prompt(promptConfig);
        }
    }
}