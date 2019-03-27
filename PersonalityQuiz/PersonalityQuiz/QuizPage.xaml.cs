using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace PersonalityQuiz
{
    public partial class QuizPage : ContentPage
    {
        public static int qNumber = 0;
        public static int[] calcs = {0,0,0,0};
        public static string[] pers = { "Iron Man", "Hulk", "Superman", "SpiderMan" };

        //List<Question> QuestionList;
        public QuizPage()
        {
            InitializeComponent();

            for (int i = 0; i < calcs.Length; i++)
            {
                calcs[i] = 0;
            }
            qNumber = 0;

            Questions q = new Questions();
            nextPage();

        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        void OnAnswer1Clicked(object sender, EventArgs e)
        {
            calcs[0]++;
            nextPage();
        }

        void OnAnswer2Clicked(object sender, EventArgs e)
        {
            calcs[1]++;
            nextPage();
        }

        void OnAnswer3Clicked(object sender, EventArgs e)
        {
            calcs[2]++;
            nextPage();
        }

        void OnAnswer4Clicked(object sender, EventArgs e)
        {
            calcs[3]++;
            nextPage();
        }

        void nextPage()
        {
            if (qNumber < Questions.QuestionList.Count)
            {
                Answer1.Text = Questions.QuestionList[qNumber].Answer1;
                Answer2.Text = Questions.QuestionList[qNumber].Answer2;
                Answer3.Text = Questions.QuestionList[qNumber].Answer3;
                Answer4.Text = Questions.QuestionList[qNumber].Answer4;
                QuestionText.Text = Questions.QuestionList[qNumber].Prompt;
                qNumber++;
            }
            else
            {
                // Hide Buttons
                Answer1.IsVisible = false;
                Answer2.IsVisible = false;
                Answer3.IsVisible = false;
                Answer4.IsVisible = false;
                // Determine and display
                int maxVal = calcs.Max();
                string idx = pers[Array.IndexOf(calcs,maxVal)];
                QuestionText.Text = "You Are " + idx.ToString();

            }
        }
    }
}
