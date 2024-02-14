using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstTestAppXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Day3LoginPage : ContentPage
    {
        public Day3LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (userName.Text == "admin")
            {
                if (password.Text == "admin")
                {
                    DisplayAlert("Success", "Login success", "ok");
                }
                else { 
                    DisplayAlert("Alert", "Password is wrong", "Ok");
                }
            }
            else
            {
                DisplayAlert("Alert", "Username is wrong", "Ok");
                userName.Text = "";
                password.Text = "";
            }
        }
    }
}