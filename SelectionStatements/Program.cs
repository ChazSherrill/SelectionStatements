using System;

namespace SelectionStatements
{
    class Program
    {

        public static string YourSubject(string yourSubject)
        {
            switch (yourSubject.ToLower())
            {
                case "math": return "math is for nerds";
                case "english": return "didn't you speak english at home";
                case "science": return "ok dexter's laboratory";
                case "history": return "what happened happened let it go";
                case "coding": return "you have no girl friend";
                case "music": return "band geek";
                default: return "You're probably not learneded";
            }
        }
            static void Main(string[] args)
            {
               
                Console.WriteLine("Whtat's your favorite subject?");

                string subject = Console.ReadLine();

                Console.WriteLine(YourSubject(subject));


            }
        
    }
}
