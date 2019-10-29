using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (entryName.Text == "" || entryName.Text == null )
            {
                await DisplayAlert("Error","Please enter a name", "Ok" );
                return;

            }
            if (entryEmail.Text == "" || entryEmail.Text == null)
            {
                await DisplayAlert("Error", "Please enter an email", "Ok");
                return;

            }
            if (entrySubject.Text == "" || entrySubject.Text == null)
            {
                await DisplayAlert("Error", "Please enter a subject", "Ok");
                return;

            }
            if (entryName.Text == "" || entryName.Text == null)
            {
                await DisplayAlert("Error", "Please enter a messsage", "Ok");
                return;

            }
            await DisplayAlert("Thank you", "Sent!", "Ok");

            Navigation.PopAsync();
        }
    }
}