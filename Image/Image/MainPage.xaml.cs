using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Image
{
    public partial class MainPage : ContentPage
    {
        public static int QuestionNumber = -1;
        public static int TotalCorrect = 0;
        public CardList c = new CardList();

        public MainPage()
        {
            InitializeComponent();
        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            UserResponse(e.Direction);
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
                NextQuestion();   
        }

        void CardsComplete()
        {
            Label1.Text = "You have reached the end of these flashcards!";
            btnStart.IsVisible = true;
            btnStart.Text = "Play Again";
        }

        async void NextQuestion()
        {
            btnStart.IsVisible = false;
            QuestionNumber++;

            if (QuestionNumber < CardList.lst.Count)
            { 
                Label1.Text = CardList.lst[QuestionNumber].Question;
            }
            else
            {
                Label1.Text = "";
                var alertText = "Stats:";
                alertText += "\n\n Total Questions:  " + (QuestionNumber);
                alertText += "\n Total Incorrect: " + ((QuestionNumber) - TotalCorrect);

                await DisplayAlert("Stack Complete", alertText, "OK");
                QuestionNumber = -1;
                TotalCorrect = 0;

                CardList.lst.Clear();
                CardList.lst.AddRange(IncorrectCards.incorrect);
                IncorrectCards.incorrect.Clear();

                if (CardList.lst.Count == 0)
                {
                    c.ResetCardList();
                    bool answer = await DisplayAlert("Question?", "Would you like to play again", "Yes", "No");
                    if (answer)
                    {
                        //restart
                        NextQuestion();
                    }
                    else
                    {
                        CardsComplete();
                    }
                }
                else
                {
                    NextQuestion();  
                }
            }
        }

        void UserResponse(SwipeDirection UserResp) {
            Boolean response = false;
            if (UserResp == SwipeDirection.Left){  
                response = true;
            }

            btnStart.IsVisible = true;
            btnStart.Text = "Next Card...";
            Boolean AnswerResult = CardList.lst[QuestionNumber].Answer;
            if (response == AnswerResult)
            {
                Label1.Text = "Congratulations!  That is correct.";
                CardList.lst[QuestionNumber].IsCorrect = true;
                TotalCorrect++;
            }
            else
            {
                Label1.Text = "I'm Sorry. That is Incorrect.";
                IncorrectCards.incorrect.Add(CardList.lst[QuestionNumber]);
            }
        }
    }
}
