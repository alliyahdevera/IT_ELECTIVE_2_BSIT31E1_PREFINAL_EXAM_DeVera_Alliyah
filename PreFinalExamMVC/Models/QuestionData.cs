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

            list.Add(new Question
            {
                Id = 4,
                Text = "Which EF Core component is primarily responsible for communicating with the database?",
                ChoiceA = "DbContext",
                ChoiceB = "DbSetView",
                ChoiceC = "ControllerContext",
                ChoiceD = "RazorContext",
                Answer = "DbContext"
            });

            list.Add(new Question
            {
                Id = 5,
                Text = "What does 'dotnet ef dbcontext scaffold' primarily do?",
                ChoiceA = "Deletes the database",
                ChoiceB = "Creates a new MVC project",
                ChoiceC = "Generates EF Core models and a DbContext from an existing database",
                ChoiceD = "Starts the MVC application",
                Answer = "Generates EF Core models and a DbContext from an existing database"
            });

            return list;
        }

        public static List<Question> GetTopic2()
        {
            List<Question> list = new List<Question>();

            list.Add(new Question
            {
                Id = 6,
                Text = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                ChoiceA = "Program.cs only",
                ChoiceB = "appsettings.json",
                ChoiceC = "Index.cshtml",
                ChoiceD = "Student.cs",
                Answer = "appsettings.json"
            });

            list.Add(new Question
            {
                Id = 7,
                Text = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                ChoiceA = "One-to-One",
                ChoiceB = "One-to-Many",
                ChoiceC = "Many-to-Many",
                ChoiceD = "Many-to-One only",
                Answer = "One-to-Many"
            });

            list.Add(new Question
            {
                Id = 8,
                Text = "In the following example, what is SectionId?\n\n" +
                       "public int SectionId { get; set; }\n" +
                       "public Section Section { get; set; }",
                ChoiceA = "Primary key of Student",
                ChoiceB = "Foreign key referencing Section",
                ChoiceC = "Navigation property",
                ChoiceD = "Database connection string",
                Answer = "Foreign key referencing Section"
            });

            return list;
        }
    }
}
