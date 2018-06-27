using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JumpIN
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginRegister : ContentPage
	{
		public LoginRegister ()
		{
            LoadStyle();
            Label lb = new Label();
            lb.Text = "Tschou";
        }

        public void LoadStyle()
        {
            Label lb = new Label();
            lb.Text = "Tschou";
        }
	}
}