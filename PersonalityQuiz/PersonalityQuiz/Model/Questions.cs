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
                Questions.QuestionList.Add(new Question { Prompt = "Question2", Answer1 = "ans2-1", Answer2 = "ans2-2", Answer3 = "ans2-3", Answer4 = "ans2-4" });
                Questions.QuestionList.Add(new Question { Prompt = "Question3", Answer1 = "ans3-1", Answer2 = "ans3-2", Answer3 = "ans3-3", Answer4 = "ans3-4" });
                Questions.QuestionList.Add(new Question { Prompt = "Question4", Answer1 = "ans4-1", Answer2 = "ans4-2", Answer3 = "ans4-3", Answer4 = "ans4-4" });
                Questions.QuestionList.Add(new Question { Prompt = "Question5", Answer1 = "ans5-1", Answer2 = "ans5-2", Answer3 = "ans5-3", Answer4 = "ans5-4" });

            }


        }



    }
}