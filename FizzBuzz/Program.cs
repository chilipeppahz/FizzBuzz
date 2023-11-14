class Program
{
    static void Main()
    {
        var fizzBuzz = new FizzBuzz();

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(fizzBuzz.GetFizzBuzzResult(i));
        }
    }
}
