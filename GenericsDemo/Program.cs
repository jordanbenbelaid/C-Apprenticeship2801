namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GenericClass<int> IntegerBox = new GenericClass<int>(123);
            GenericClass<string> StringBox = new GenericClass<string>("Hello");
            GenericClass<double> DoubleBox = new GenericClass<double>(2.45);


            Console.WriteLine($"Integer box: {IntegerBox}");
            Console.WriteLine(IntegerBox.GetItem());

            Console.WriteLine($"String box: {StringBox}");
            Console.WriteLine(StringBox.GetItem());

            Console.WriteLine($"Double box: {DoubleBox}");
            Console.WriteLine(DoubleBox.GetItem());

            //List<string> StringList = new List<string>();
            //StringList.Add("Jordan");
            //StringList.Add("Tim");
            //StringList.Add("Jamie");
            //StringList.Add("Ellis");

            //for (int i = 0; i < StringList.Count; i++)
            //{
            //    Console.WriteLine(StringList[i]);
            //}

            //foreach(string s in StringList)
            //{
            //    Console.WriteLine(s);
            //}

            //Console.WriteLine("========================================================");

            //List<string> LongNames = StringList.Where(n => n.StartsWith("J")).ToList();
            //foreach (string s in LongNames)
            //{
            //    Console.WriteLine(s);
            //}

            //string Name = StringList.Find(n => n == "Jord");
            //Console.WriteLine(Name);
        }
    }
}
