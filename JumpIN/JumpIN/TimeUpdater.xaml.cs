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
	public partial class TimeUpdater : ContentPage
	{
		
        private DayOfWeek today;
        private String currentYear = DateTime.Now.Year.ToString();

        public TimeUpdater(Label day, Label year)
        {
            today = DateTime.Now.DayOfWeek;
            String currently = Convert.ToString(today);
            day.Text = currently;
            year.Text = currentYear;
        }
	}
}