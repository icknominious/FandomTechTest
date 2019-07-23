using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Acr.UserDialogs;

using FTT.Models;
using FTT.Data;

namespace FTT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTeam : ContentPage
    {
        public NewTeam()
        {
            InitializeComponent();
        }

        private void CreateButton_Clicked(object sender, EventArgs e)
        {
            if (nameEntry.Text == null || Logo.Source == null)                                  //If missing necessary data to create a team, ignore button click and warn user.
            {
                ToastConfig errorToastConfig = new ToastConfig("New Team form imcomplete");
                errorToastConfig.SetDuration(1000);
                errorToastConfig.SetBackgroundColor(Color.DimGray);
                UserDialogs.Instance.Toast(errorToastConfig);
                return;
            }

            Team newTeam = new Team();                                                          //Otherwise create new team by matching form data to attributes and add to team list.
            newTeam.Name = nameEntry.Text;
            newTeam.Image = Logo.Source.ToString().Replace("Uri: ", "");

            TeamData.TeamList.Add(newTeam);
            TeamData.teamNames.Add(newTeam.Name);

            ToastConfig toastConfig = new ToastConfig("Team Created");                          //Prompt user that a team was created.
            toastConfig.SetDuration(1000);
            toastConfig.SetBackgroundColor(Color.DimGray);
            UserDialogs.Instance.Toast(toastConfig);
            
     }

        private void PictureButton_Clicked(object sender, EventArgs e)
        {
            PromptConfig promptConfig = new PromptConfig();
            Action<PromptResult> promptAction = promptResult =>                                 //Action taken when confirm button on prompt is pressed.
            {
                Logo.Source = promptResult.Text;
            };
            promptConfig.Message = "Enter picture URL";                                         //Prompt user to enter a picture url.
            promptConfig.Placeholder = Logo.Source.ToString().Replace("Uri: ", "");
            promptConfig.OkText = "Confirm";
            promptConfig.CancelText = "Cancel";
            promptConfig.OnAction = promptAction;
            UserDialogs.Instance.Prompt(promptConfig);
        }
    }
}