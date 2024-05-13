namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello please choose from the differnt databases to veiw our cards and prices.\n Pokemon cards are in the List Data base\nYuGiOh cards are in the SQL database\nMagic the Gathering cards are in the Mongo database.");
            string cardType = Console.ReadLine();

            IDataAccess ct = DataAccessFactory.GetCards(cardType);
            if (ct != null)
            {
                List<Product> products = ct.LoadData();

                Console.WriteLine("###################################");

                Console.WriteLine("Here are you cards!");
                for (int index = 0; index < products.Count; index++)
                {
                    Console.WriteLine($"Card Name: {products[index].Name} || Price: {products[index].Price,0:c}");
                }
                Console.WriteLine("Do you wish to save your data? Y/N");
                string saveChoice = Console.ReadLine();

                if (saveChoice.ToLower() == "y")
                {
                    ct.SaveData(List<Product> products);
                    Console.WriteLine("Your cards were saved to the Database.");
                }

            }


        }
           
    }
}
