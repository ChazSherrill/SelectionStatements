using System;

namespace SelectionStatements
{
    class Program
    {

       
        
            static void Main(string[] args)
            {
               
                Console.WriteLine("Whtat's your favorite subject?");

                string subject = Console.ReadLine();

              
            switch (subject.ToLower())
            {
                case "math": Console.WriteLine("math is for nerds");break;
                case "english": Console.WriteLine("didn't you speak english at home"); break;
                case "science": Console.WriteLine("ok dexter's laboratory"); break;
                case "history": Console.WriteLine("what happened happened let it go"); break;
                case "coding": Console.WriteLine("you have no girl friend");break;
                case "music": Console.WriteLine("band geek");break;
                default: Console.WriteLine( "You're probably not learneded");  break;
            }

            }
        
    }
}
