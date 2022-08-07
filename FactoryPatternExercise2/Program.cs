using System;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use: a List, SQL, or Mongo?");

            var answer = DataAccessFactory.GetDataAccessType(Console.ReadLine());

            answer.LoadData();
            answer.SaveData();
            
        }
    }
}

