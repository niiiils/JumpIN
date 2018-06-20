using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JumpIN
{
	public partial class MainPage : ContentPage
	{
        private DayOfWeek now;

        public MainPage()
        {
            InitializeComponent();
            BoxView box = this.FindByName<BoxView>("box1");
            now = DateTime.Now.DayOfWeek;
            String currently = Convert.ToString(now);
            Label currentlyLabel = this.FindByName<Label>("datetimeLabel");
            currentlyLabel.Text = currently;
        }
	}
}
