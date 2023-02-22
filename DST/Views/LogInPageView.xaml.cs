using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace DST.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPageView : ContentPage
    {
        public LogInPageView()
        {
            InitializeComponent();
            
        }

        private async void LogInBtn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));
            Navigation.RemovePage(this);
        }

        private async void SingUpBtn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Views.RegistrationPageView()));
         
        }
        
    }
}