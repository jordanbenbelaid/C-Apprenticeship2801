namespace ExceptionsInstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int a = 10, b = 0, result;
            //    result = a / b;
            //}
            //catch (Exception ex)
            //{
            //    Console.Error.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("This still always runs");
            //}

            try
            {
                Demo.ValidateAge(12);
            }
            catch (InvalidAgeException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This still always runs");
            }
        }
    }
}
