namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            Dictionary<string, string> WorldFoods = new Dictionary<string, string>();

            //You can put a List of a type into a dictionary as well
            //Dictionary<string, List<string>> WorldFoodsList = new Dictionary<string, List<string>>();

            WorldFoods.Add("Italy", "Pasta");
            WorldFoods.Add("Japan", "Ramen");
            WorldFoods.Add("America", "Burgers");

            Console.WriteLine($"Italy is known for {WorldFoods["Italy"]}");

            string country = "Spain";

            //Error handling to see if a key exists in the dictionary, if it does print to console,
            //if not, say it cant be found
            if (WorldFoods.ContainsKey(country))
            {
                Console.WriteLine($"{country} is known for {WorldFoods[country]}");
            } else
            {
                Console.WriteLine($"{country} is not found in the dictionary");
            }

            //Iterating through the dictionary to print the key with its value
            foreach (KeyValuePair<string, string> kvp in WorldFoods)
            {
                Console.WriteLine($"Country: {kvp.Key}, Food: {kvp.Value}");
            }

            //removing from a list
            WorldFoods.Remove("America");

            //updating a value
            WorldFoods["Italy"] = "Pizza";
        }
    }
}
