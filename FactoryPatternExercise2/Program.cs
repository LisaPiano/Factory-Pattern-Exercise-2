namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string response;
            bool answerIsCorrect;

            do

            {
                Console.Clear();
                answerIsCorrect = true;
                Console.WriteLine("Hello! What database would you like to use? Please type list, SQL, or mongo: ");
                response = Console.ReadLine();
                string lowerResponse = response.ToLower();

                if (lowerResponse != "sql" && lowerResponse != "list" && lowerResponse != "mongo")
                { 
                    Console.WriteLine("I'm sorry, that was not a valid response");
                    Thread.Sleep(1000);
                    answerIsCorrect = false;
                }
            } while
            (!answerIsCorrect);

          IDataAccess db = DataAccessFactory.GetDataAccessType(response);

           var products =  db.LoadData();
            db.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, and  Price: {product.Price}");
            }
        }
    }
}
 