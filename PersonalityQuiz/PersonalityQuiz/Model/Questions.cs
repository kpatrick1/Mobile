using System;
using System.Collections.Generic;

namespace PersonalityQuiz
{
    public class Questions
    {
        public static List<Question> QuestionList = new List<Question>();



        public Questions()
        {
            if (QuestionList.Count == 0) {
                Questions.QuestionList.Add(new Question { Prompt = "What would you do when someone upsets you?", Answer1 = "run and hide", Answer2 = "Tear their arms off", Answer3 = "Drown Them", Answer4 = "Be Nice" });
                Questions.QuestionList.Add(new Question { Prompt = "Select your Favorite", Answer1 = "Fly", Answer2 = "Jump", Answer3 = "Swim", Answer4 = "Climb" });
                Questions.QuestionList.Add(new Question { Prompt = "Breakfast Choice", Answer1 = "People", Answer2 = "Robots", Answer3 = "Small Children", Answer4 = "Starve" });
                Questions.QuestionList.Add(new Question { Prompt = "Best Time of Day for you?", Answer1 = "Morning", Answer2 = "Afternoon", Answer3 = "Evening", Answer4 = "Overnight" });
                Questions.QuestionList.Add(new Question { Prompt = "Car you drive", Answer1 = "Pickup", Answer2 = "Compact", Answer3 = "Smart", Answer4 = "Semi" });

            }


        }



    }
}