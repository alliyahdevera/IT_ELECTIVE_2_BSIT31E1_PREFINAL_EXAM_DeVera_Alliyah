using System.Collections.Generic;

namespace PreFinalExamMVC.Models
{
    public class QuestionData
    {
        public static List<Question> GetTopic1()
        {
            List<Question> list = new List<Question>();

            list.Add(new Question
            {
                Id = 1,
                Text = "What is the main problem solved by using a database instead of an in-memory collection?",
                ChoiceA = "It makes C# code shorter",
                ChoiceB = "It prevents the application from restarting",
                ChoiceC = "It allows data to persist after the application stops",
                ChoiceD = "It removes the need for MVC",
                Answer = "It allows data to persist after the application stops"
            });

            return list;
        }
    }
}
