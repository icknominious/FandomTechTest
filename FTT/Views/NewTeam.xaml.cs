using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Acr.UserDialogs;

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

        }

        private void PictureButton_Clicked(object sender, EventArgs e)
        {
            PromptConfig promptConfig = new PromptConfig();
            Action<PromptResult> promptAction = promptResult =>
            {
                Logo.Source = promptResult.Text;
            };
            promptConfig.Message = "Enter picture URL";
            promptConfig.Placeholder = Logo.Source.ToString();
            promptConfig.OkText = "Confirm";
            promptConfig.CancelText = "Cancel";
            promptConfig.OnAction = promptAction;
            UserDialogs.Instance.Prompt(promptConfig);
        }
    }
}