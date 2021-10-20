using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10._19
{
    class CircleList
    {
        public List<Circle> Circles = new List<Circle>();
        public CircleList()
        {
            //Need to create constructors for the list, so it can be built
            //Not sure how to populate the list after the fact, but thinking I need logic here and a method below to capture that info, then construct here
            //Doesnt look like I needed constructors - i think I just needed the AddToList method below, so I can call it in main
        }
        public double GetDblInput()
        {
            string output = Console.ReadLine();
            try
            {
                double userDbl = double.Parse(output);
                return userDbl;
            }
            catch (Exception e)
            {
                Console.WriteLine("I'm sorry, that is not a valid input.\n" + e.Message);
                Console.WriteLine("Please input a valid radius.");
                return GetDblInput();
            }
        }
        public void AddToList(double radius)
        {
            Circles.Add(new Circle(radius));
            for (int i = 0; i < Circles.Count; i++)
            {
                Console.WriteLine(Circles[i]);
            }
        }
        public void PrintList()
        {
            for (int i = 0; i < Circles.Count; i++)
            {
                Console.WriteLine(Circles[i]);
            }
        
        }
        


    }
}
