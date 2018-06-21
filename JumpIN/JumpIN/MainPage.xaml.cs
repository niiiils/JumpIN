using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpIN
{
    public partial class MainPage : ContentPage
    {
        private DayOfWeek today;
        private String currentYear = DateTime.Now.Year.ToString();

        public MainPage()
        {
            InitializeComponent();
            //BoxView box = this.FindByName<BoxView>("box1");

            today = DateTime.Now.DayOfWeek;
            String currently = Convert.ToString(today);
            Label currentlyLabel = this.FindByName<Label>("datetimeLabel");
            currentlyLabel.Text = currently;
            Label currentYearLabel = this.FindByName<Label>("year");
            currentYearLabel.Text = currentYear;

            
            
        }

        void OnTapped(object sender, EventArgs e)
        {
            Console.WriteLine("du larry");
        }
    }
}
