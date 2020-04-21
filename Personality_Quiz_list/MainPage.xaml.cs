using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        async void Button_Clicked_Results(Object sender, EventArgs e)
        {

            

            Button b = (Button)sender;
            b.IsVisible = false;

            if (Points <= 2 || Points == 22)
            {
                Character = "You are Emporer Palpatine";
                Image = "Palpatine.jpg";

            }
            else if (Points == 20)
            {
                Character = "You are Jar Jar Binks";
                Image = "binks.jpg";

            }
            else if (Points == 7 || Points == 27)
            {
                Character = "You are Luke Skywalker";
                Image = "Skywalker.png";
            }
            else if (Points == 3 || Points == 23)
            {
                Character = "You are Princess Leia";
                Image = "Leia.jpg";
            }
            else
            {
                Character = "You are Darth Vader";
                Image = "Vader.jpg";
            }

            

            await Navigation.PushModalAsync(new Results());


        }
    }

   

}
