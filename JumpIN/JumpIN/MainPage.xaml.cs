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
        public MainPage()
        {
            InitializeComponent();
            
            loadDate();
            dayChecker();
        }

        void OnTapped(object sender, EventArgs e)
        {
            Console.WriteLine("du larry");
        }

        public void dayChecker()
        {
            Frame bioFrame = this.FindByName<Frame>("bio");
            DayChecking dC = new DayChecking(bioFrame);
        }

        public void loadDate()
        {
            Label currentlyLabel = this.FindByName<Label>("datetimeLabel");
            Label currentYearLabel = this.FindByName<Label>("year");
            TimeUpdater tU = new TimeUpdater(currentlyLabel,currentYearLabel);
        }
    }
}
