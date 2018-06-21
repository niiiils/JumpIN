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
            //BoxView box = this.FindByName<BoxView>("box1")
            loadDate();
        }

        void OnTapped(object sender, EventArgs e)
        {
            Console.WriteLine("du larry");
        }

        public void loadDate()
        {
            Label currentlyLabel = this.FindByName<Label>("datetimeLabel");
            Label currentYearLabel = this.FindByName<Label>("year");
            TimeUpdater tU = new TimeUpdater(currentlyLabel,currentYearLabel);
        }
    }
}
