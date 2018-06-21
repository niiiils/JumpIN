using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace JumpIN
{
	public class DayChecking
	{
        private String today = DateTime.Now.DayOfWeek.ToString();
        public DayChecking (Frame bio)
		{
			if(today!="Monday" || today!="Tuesday") {
                bio.IsVisible = false;
            }
		}
	}
}