using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        /*
        public List<string> images = new List<String>
        {
            "testy","testpng"
        };
        */
        //int index = 0;
        public MainPage()
        {
            InitializeComponent();
            
        }
        /*
        void next_clicked(Object sender, EventArgs args)
        {
            next();
        }
        private void next()
        {
            the_image.Source = images[index++];
            if (index >= images.Count)
            {
                index = 0;
            }
        }
        void previous_clicked(Object sender, EventArgs args)
        {
            prev();
        }
        public void prev()
        {
            the_image.Source = images[index--];
            if (index <= 0)
            {
                index = images.Count - 1;
            }
        }
        void OnSwiped(Object sender, SwipedEventArgs e)
        {
            if(e.Direction == SwipeDirection.Right)
            {
                next();
            }
            else
            {
                prev();
            }
        }

        */
        int score = 0;
        // Swipe right add +3 to score. On left do not add
        void OnSwiped(Object sender, SwipedEventArgs e)
        {
            if (e.Direction == SwipeDirection.Right)
            {
                lastResult.Text = "last result: true";
                score += 3;
            }
            else
            {
                lastResult.Text = "last result: false";
            }
            nextQuestion();

        }
        int index = 0;

        public List<string> questions = new List<String>
        {
            "You feel like more of an extrovert","You like being outside.", "You would rather plays sports over video games", "Wyoming is a fake state", "You enjoy this quiz", "This is true."
        };
        public List<string> persons = new List<String>
        {
            "chewie","mike", "droid", "jarjar"
        };
        public void nextQuestion()
        {
            question_label.Text = questions[index++];
            if (index >= questions.Count())
            {
                question_label.IsVisible = false;
                displayCharacter();
            }
        }

        public void displayCharacter()
        {
            lastResult.Text = "You are:";
            the_image.IsVisible = true;
            if(score >= 15)
            {
                the_image.Source = persons[0] + ".png";
                lastResult.Text += persons[0];
            }else if(score>=12){
                the_image.Source = persons[1]+ ".png";
                lastResult.Text += persons[1];
            }
            else if(score>= 9)
            {
                the_image.Source = persons[2] + ".png";
                lastResult.Text += persons[2];

            }
            else
            {
                the_image.Source = persons[3] + ".png";
                lastResult.Text += persons[3];

            }
        }
        void start_clicked(Object sender, EventArgs args)
        {
            start_btn.IsVisible = false;
            if (yourName.Text.Length > 15)
            {
                score += 4;
            }
            if(yourAge.Text.Length > 1)
            {
                score += 1;
            }
            yourName.IsVisible = false;
            yourAge.IsVisible = false;
            question_label.IsVisible = true;
            lastResult.IsVisible = true;
            nextQuestion();
        }


    }
}
