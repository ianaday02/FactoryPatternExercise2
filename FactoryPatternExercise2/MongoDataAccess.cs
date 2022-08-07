using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from the Mongo database");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from the Mongo database");
        }
    }
}

