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
        public static Boolean ShowResults = false;
        public CardList c = new CardList();
        public MainPage()
        {
            InitializeComponent();

        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    // Handle the swipe
                    //DisplayAlert("Swipe", "Swipe Left", "Cancel");
                    if (!ShowResults)
                    {
                        UserCorrect();
                    }
                    break;
                case SwipeDirection.Right:
                    // Handle the swipe
                    //DisplayAlert("Swipe", "Swipe Right", "Cancel");
                    if (!ShowResults)
                    {
                        UserIncorrect();
                    }
                    break;
                case SwipeDirection.Up:
                    // Handle the swipe
                    //DisplayAlert("Swipe", "Swipe Up", "Cancel");
                    if (!ShowResults)
                    {
                        NextQuestion();
                    }
                    break;
                case SwipeDirection.Down:
                    // Handle the swipe
                    if (ShowResults)
                    {
                        if (CardList.lst.Count == 0) {
                            c.ResetCardList();
                            CardsComplete();
                        }
                        ShowResults = false;
                        NextQuestion();
                    }
                    break;
            }
        }

        void CardsComplete()
        {
            Label1.Text = "You have reached the end of these flashcards!";
        }

        void NextQuestion()
        {
            QuestionNumber++;

            if (QuestionNumber < CardList.lst.Count)
            { 
                Label1.Text = CardList.lst[QuestionNumber].Question;
            }
            else
            {
                Label1.Text = "You have Completed: Here are your Results...";
                Label1.Text += "\n Total Questions: " + (QuestionNumber);
                Label1.Text += "\n Total Incorrect: " + ((QuestionNumber) - TotalCorrect);
                Label1.Text += "\n\n\n Swipe down to go through incorrect choices";
                QuestionNumber = -1;
                TotalCorrect = 0;
                ShowResults = true;
                CardList.lst.Clear();
                CardList.lst.AddRange(IncorrectCards.incorrect);
                IncorrectCards.incorrect.Clear();
            }

        }

        void UserCorrect()
        {
            Boolean AnswerResult = CardList.lst[QuestionNumber].Answer;
            Label1.Text = "The Correct Anser Is: " + AnswerResult.ToString() + "\n You chose 'True' \n\n Swipe up for Next Question!";
            if (AnswerResult)
            {
                CardList.lst[QuestionNumber].IsCorrect = true;
                TotalCorrect++;
            }
            else
            {
                IncorrectCards.incorrect.Add(CardList.lst[QuestionNumber]);
            }
        }

        void UserIncorrect()
        {
            Boolean AnswerResult = CardList.lst[QuestionNumber].Answer;
            Label1.Text = "The Correct Anser Is: " + AnswerResult.ToString() + "\n You chose 'False' \n\n Swipe up for Next Question!";
            if (!AnswerResult)
            {
                CardList.lst[QuestionNumber].IsCorrect = true;
                TotalCorrect++;
            }
            else
            {
                IncorrectCards.incorrect.Add(CardList.lst[QuestionNumber]);
            }

        }

    }
}
