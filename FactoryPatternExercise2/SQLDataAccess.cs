using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from the SQL database");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from the SQL database");
        }
    }
}

