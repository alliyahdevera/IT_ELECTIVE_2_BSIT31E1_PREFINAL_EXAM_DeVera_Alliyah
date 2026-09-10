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

            list.Add(new Question
            {
                Id = 9,
                Text = "What is the purpose of a navigation property such as 'public Section Section { get; set; }'?",
                ChoiceA = "It stores the database password",
                ChoiceB = "It represents a relationship to another entity",
                ChoiceC = "It creates a new database",
                ChoiceD = "It validates the student's name",
                Answer = "It represents a relationship to another entity"
            });

            list.Add(new Question
            {
                Id = 10,
                Text = "What does .Include() generally allow EF Core to do?",
                ChoiceA = "Delete the Section table",
                ChoiceB = "Load related Section data together with Students",
                ChoiceC = "Create a new Student",
                ChoiceD = "Validate Student input",
                Answer = "Load related Section data together with Students"
            });

            return list;
        }

        public static List<Question> GetTopic3()
        {
            List<Question> list = new List<Question>();

            list.Add(new Question
            {
                Id = 11,
                Text = "Why might a ViewModel be used when displaying Student and Section information?",
                ChoiceA = "To replace the database",
                ChoiceB = "To combine or shape the data specifically needed by the view",
                ChoiceC = "To automatically create database tables",
                ChoiceD = "To prevent controllers from using LINQ",
                Answer = "To combine or shape the data specifically needed by the view"
            });

            list.Add(new Question
            {
                Id = 12,
                Text = "What is the main benefit of using Include(s => s.Section) in a query?",
                ChoiceA = "It loads the related Section navigation property",
                ChoiceB = "It creates a Section object manually",
                ChoiceC = "It removes the foreign key",
                ChoiceD = "It prevents the query from accessing the database",
                Answer = "It loads the related Section navigation property"
            });

            list.Add(new Question
            {
                Id = 13,
                Text = "Which type of validation occurs in the browser before a request is sent to the server?",
                ChoiceA = "Database-level validation",
                ChoiceB = "Client-side validation",
                ChoiceC = "Server-side validation",
                ChoiceD = "EF Core migration validation",
                Answer = "Client-side validation"
            });

            list.Add(new Question
            {
                Id = 14,
                Text = "Why is server-side validation still necessary if client-side validation exists?",
                ChoiceA = "Client-side validation can be bypassed",
                ChoiceB = "Client-side validation automatically modifies the database",
                ChoiceC = "Server-side validation only works with SQLite",
                ChoiceD = "Client-side validation cannot display messages",
                Answer = "Client-side validation can be bypassed"
            });

            list.Add(new Question
            {
                Id = 15,
                Text = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                ChoiceA = "Student Number should always be nullable",
                ChoiceB = "Student Number should be unique",
                ChoiceC = "Student Number should always be the same",
                ChoiceD = "Student Number should contain only spaces",
                Answer = "Student Number should be unique"
            });

            return list;
        }

        public static List<Question> GetTopic4()
        {
            List<Question> list = new List<Question>();

            list.Add(new Question
            {
                Id = 16,
                Text = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                ChoiceA = "It protects data integrity even if application-level validation is bypassed",
                ChoiceB = "It makes Razor Views render faster",
                ChoiceC = "It removes the need for a Controller",
                ChoiceD = "It automatically creates a ViewModel",
                Answer = "It protects data integrity even if application-level validation is bypassed"
            });

            list.Add(new Question
            {
                Id = 17,
                Text = "What is the purpose of a try...catch block in a controller?",
                ChoiceA = "To create navigation properties",
                ChoiceB = "To catch and handle exceptions that may occur during execution",
                ChoiceC = "To generate database tables",
                ChoiceD = "To perform client-side validation",
                Answer = "To catch and handle exceptions that may occur during execution"
            });

            return list;
        }
    }
}
