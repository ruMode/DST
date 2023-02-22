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
	public partial class RegistrationPageView : ContentPage
	{
		public RegistrationPageView ()
		{
			InitializeComponent ();
			
		}

        private void regBtn_Clicked(object sender, EventArgs e)
        {

        }
	
    }
}