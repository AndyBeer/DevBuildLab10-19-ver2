using System;

namespace DevBuildLab10._19
{
    class Program
    {
        static void Main(string[] args)
        {

            bool keepGoing = true;
            
            CircleList Circles = new CircleList();

            while (keepGoing)
            {
                Console.Write("Please input a radius for your circle: ");
                
                double radius = Circles.GetDblInput();

                Circles.AddToList(radius);
                
                keepGoing = ContinueLoop("Would you like to add another circle?");
            }

        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            return response;
        }
        public static bool ContinueLoop(string question)
        {
            string answer = GetInput(question);
            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("OK, goodbye!");
                return false;
            }
            else
            {
                return ContinueLoop("I'm sorry, I didnt catch that.  Please input y to try again, or n to exit.");
            }
        }



    }
}
