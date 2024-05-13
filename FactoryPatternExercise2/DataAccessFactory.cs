using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetCards(string cardType)
        {
            while (true)
            {
                switch (cardType.ToLower())
                {
                    case "pokemon":
                    case "list":
                        return new ListDataAccess();

                    case "yugioh":
                    case "sql":
                        return new SQLDataAcess();

                    case "magic the gathering":
                    case "mongo":
                        return new MongoDataAcess();

                    case "Exit":
                        Console.WriteLine("Exiting the Database");
                        Environment.Exit(0);
                        return null;

                    default:
                        Console.WriteLine("Please choose from the correct Data bases.");
                        return null;
                }

            }
        }
    }
}
