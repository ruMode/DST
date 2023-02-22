using Android.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

namespace DST
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            currentDateLabel.Text = DateTime.Now.ToShortDateString();

            List<SheduleItems> shedule = new List<SheduleItems>();

            shedule.Add(new SheduleItems()
            {
                Counter = 1,
                Subject = "subject",
                Group = "is-407"

            });
            shedule.Add(new SheduleItems()
            {
                Counter = 2,
                Subject = "subject",
                Group = "is-407"

            });
            shedule.Add(new SheduleItems()
            {
                Counter = 3,
                Subject = "subject",
                Group = "is-407"

            });

            shedule.Add(new SheduleItems()
            {
                Counter = 4,
                Subject = "subject",
                Group = "is-407"

            });

            shedule.Add(new SheduleItems()
            {
                Counter = 5,
                Subject = "subject",
                Group = "is-407"

            });

            sheduleCV.ItemsSource = shedule;

           
        }

        private void sheduleCV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private async void btnScan_Clicked(object sender, EventArgs e)
        {

            //#if __ANDROID__
	           //             // Initialize the scanner first so it can track the current context
	           //             MobileBarcodeScanner.Initialize (Application);
            //#endif

            var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            var result = await scanner.Scan();

            if (result != null)
            {
                await DisplayAlert("title", result.Text, "ok");

            }


        }
    }
}
