using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JumpIN
{
	public partial class TimeUpdater
	{
		
        private DayOfWeek today;
        private String currentYear = DateTime.Now.Year.ToString();
        

        public TimeUpdater(Label day, Label year)
        {
            today = DateTime.Now.DayOfWeek;
            String currently = Convert.ToString(today);
            day.Text = currently + ",   " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
            year.Text = currentYear;
        }
	}
}