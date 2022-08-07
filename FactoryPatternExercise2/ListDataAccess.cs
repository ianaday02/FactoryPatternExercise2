using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine("I am saving data from the list database");
        }

        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine("I am reading data from the list database");
            return new List<Product>();
        }
    }
}

