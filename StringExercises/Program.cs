using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string beautifulPoetry = "I would not, could not, in a box. I would not, could not with a fox.\nI will not eat them in a house. I will not eat them with a mouse.";
            string[] fragmentedPoetry = beautifulPoetry.Split(".");

            Console.WriteLine(string.Join(",", fragmentedPoetry));
        }
    }
}
