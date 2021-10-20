using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10._19
{
    class Circle
    {
        public double Radius { get; set; }
        public double Circumference => Math.Round((2 * Math.PI * Radius),2);
        public double Area => Math.Round((Math.PI * (Math.Pow(Radius, 2))), 2);

        public Circle(double Radius)
        {
            this.Radius = Radius;

        }
        public override string ToString()
        {
            //return base.ToString();
            string output = $"Circle Radius: {Radius}\nCirumference: {Circumference}\nArea: {Area}\n";
            return output;

        }
        //public double GetDblInput()
        //{
        //    string output = Console.ReadLine();
        //    try
        //    {
        //        double userDbl = double.Parse(output);
        //        return userDbl;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("I'm sorry, that is not a valid input.\n" + e.Message);
        //        Console.WriteLine("Please input a valid radius.");
        //        return GetDblInput();
        //    }
        //}
        //public string GetInput(string prompt)
        //{
        //    Console.WriteLine(prompt);
        //    string output = Console.ReadLine();
        //    return output;
        //}
        
    }
}
