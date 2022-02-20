using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Program");
            string message = " ";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            Console.WriteLine(moodAnalyser.AnalyzeMood()); 
        }
    }
}
