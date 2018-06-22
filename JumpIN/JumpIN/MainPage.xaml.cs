using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpIN
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Card> cards = new ObservableCollection<Card>();
        public MainPage()
        {
            
            InitializeComponent();
            createMenuItem("aletsch.jpg", "White", "Schreibe dich hier für eine Aktivität ein!");
            createMenuItem("wanderung1.jpg", "White", "Schreibe ein Steckbrief über dich!");
            createMenuItem("galerie1.jpg", "White", "Schau dir die Fotos des JumpIn an!");
            loadDate();
            
        }

        void OnTapped(object sender, EventArgs e)
        {
            Console.WriteLine("du larry");
            
        }

        public void createMenuItem(String image,String textColor,String text)
        {
            cards.Add(
                new Card { imgName = image, txtColor = textColor, txtOnImage = text}
            );
            ListView lv = this.FindByName<ListView>("Cards");
            lv.ItemsSource = cards;
        }

        // loads the date of the current day
        public void loadDate()
        {
            Label currentlyLabel = this.FindByName<Label>("datetimeLabel");
            Label currentYearLabel = this.FindByName<Label>("year");
            TimeUpdater tU = new TimeUpdater(currentlyLabel,currentYearLabel);
        }
    }
}