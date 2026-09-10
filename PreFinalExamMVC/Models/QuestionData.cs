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

            list.Add(new Question
            {
                Id = 2,
                Text = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                ChoiceA = "Code-First",
                ChoiceB = "Database-First",
                ChoiceC = "Model-First",
                ChoiceD = "Controller-First",
                Answer = "Database-First"
            });

            list.Add(new Question
            {
                Id = 3,
                Text = "What is the primary purpose of Entity Framework Core?",
                ChoiceA = "To create HTML pages automatically",
                ChoiceB = "To replace the MVC Controller",
                ChoiceC = "To map objects in code to relational database data",
                ChoiceD = "To replace the C# compiler",
                Answer = "To map objects in code to relational database data"
            });

            return list;
        }
    }
}
