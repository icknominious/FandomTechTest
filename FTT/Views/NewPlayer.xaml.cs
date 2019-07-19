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
            if (nameEntry.Text == null || Picture.Source == null || teamPicker.SelectedItem == null)
            {
                ToastConfig errorToastConfig = new ToastConfig("New Player form incomplete");
                errorToastConfig.SetDuration(1000);
                errorToastConfig.SetBackgroundColor(Color.DimGray);
                UserDialogs.Instance.Toast(errorToastConfig);
                return;
            }

            Player newPlayer = new Player();
            newPlayer.Name = nameEntry.Text;
            newPlayer.Image = Picture.Source.ToString().Replace("Uri: ", "");
            Int32.TryParse(goalsEntry.Text, out int x);
            Int32.TryParse(assistsEntry.Text, out int y);
            newPlayer.Goals = x;
            newPlayer.Assists = y;
            newPlayer.Team = teamPicker.SelectedItem.ToString();

            PlayerData.PlayerList.Add(newPlayer);
            ToastConfig toastConfig = new ToastConfig("Player created");
            toastConfig.SetDuration(1000);
            toastConfig.SetBackgroundColor(Color.DimGray);
            UserDialogs.Instance.Toast(toastConfig);
            
        }

        private void PictureButton_Clicked(object sender, EventArgs e)
        {
            PromptConfig promptConfig = new PromptConfig();
            Action<PromptResult> promptAction = promptResult =>
            {
                Picture.Source = promptResult.Text;
            };
            promptConfig.Message = "Enter picture URL";
            promptConfig.Placeholder = Picture.Source.ToString().Replace("Uri: ", "");
            promptConfig.OkText = "Confirm";
            promptConfig.CancelText = "Cancel";
            promptConfig.OnAction = promptAction;
            UserDialogs.Instance.Prompt(promptConfig);
        }
    }
}