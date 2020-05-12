using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personality_Quiz_list.Data;
using Xamarin.Forms;

namespace Personality_Quiz_list
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private int Points = 0;
        public static string Character { get; set; }
        public static string Image { get; set; }
        public string Result { get; set; }
        
 

        public MainPage()
        {

            BindingContext = this;
            InitializeComponent();

        }

        void True_Clicked(System.Object sender, System.EventArgs e)
        {

            var button = (Button)sender;          
         
            Question question = button.CommandParameter as Question;
            Points += question.PointValue;

            Question.All.Remove(question);

            questionList.ItemsSource = "";
            questionList.ItemsSource = Question.All;
             
           
        }

        void False_Clicked(Object sender, EventArgs e)
        {
            var button = (Button)sender;
            Question question = button.CommandParameter as Question;

            Question.All.Remove(question);
            questionList.ItemsSource = "";
            questionList.ItemsSource = Question.All;


        }

        // Method now uses API to get the character name, then adds it to the main Character string. There are no pictures in the API.
        async void Button_Clicked_Results(Object sender, EventArgs e)
        {
            string character = string.Empty;
            

            Button b = (Button)sender;
            b.IsVisible = false;

            if (Points <= 2 || Points == 22)
            {
                character = await App.SWManager.GetCharacter("Palpatine");
                Image = "Palpatine.jpg";

            }
            else if (Points == 20)
            {
                character = await App.SWManager.GetCharacter("Binks");
                Image = "binks.jpg";

            }
            else if (Points == 7 || Points == 27)
            {
                character = await App.SWManager.GetCharacter("Luke Skywalker");
                Image = "Skywalker.png";
            }
            else if (Points == 3 || Points == 23)
            {
                character = await App.SWManager.GetCharacter("Leia"); ;
                Image = "Leia.jpg";
            }
            else
            {
                character = await App.SWManager.GetCharacter("Vader"); ;
                Image = "Vader.jpg";
            }


            Character = $"You are {character}";

            await Navigation.PushModalAsync(new Results());


        }

      
    }

   

}
