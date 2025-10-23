namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first method adds two integers.\nPlease, type the first integer.");
            int integer1 = TryParseLoop_Int();
            
            Console.WriteLine("Please, type the second integer.");
            int integer2 = TryParseLoop_Int();

            Console.WriteLine($"The sum of {integer1} and {integer2} is {Add(integer1, integer2)}.");
            
            Console.WriteLine("\nThe second method adds two decimals.\nPlease, type the first decimal.");
            decimal decimal1 = TryParseLoop_Decimal();

            Console.WriteLine("Please, type the second decimal.");
            decimal decimal2 = TryParseLoop_Decimal();

            Console.WriteLine($"The sum of  {decimal1} and {decimal2} is {Add(decimal1, decimal2)}.");

            Console.WriteLine("\nThe third method counts dollar bills!");
            Console.WriteLine("Please, count the number of dollar bills in the safe or count the number of dollar bills missing from the safe.");
            Console.WriteLine("Type a positive integer when bills are on hand.");
            Console.WriteLine("Type zero when the safe is flawlessly empty.");
            Console.WriteLine("Type a negative integer when counting the number of bills missing from the safe.");
            int cash1 = TryParseLoop_Int();

            Console.WriteLine("Please, count the number of dollar bills in the cash drawer or missing from the cash drawer.");
            int cash2 = TryParseLoop_Int();
            
            bool trueOrFalse;
            if (cash1 + cash2 == 1)
            {
                trueOrFalse = true;
            }
            else
            {
                trueOrFalse = false;
            }
            
            Console.WriteLine($"{Add(cash1, cash2, trueOrFalse)}");
        }

        static int Add(int integer1, int integer2)
        {
            int integerSum = integer1 + integer2;
            return integerSum;
        }

        static decimal Add(decimal decimal1, decimal decimal2)
        {
            decimal decimalSum = decimal1 + decimal2;
            return decimalSum;
        }

        static string Add(int cash1, int cash2, bool trueOrFalse)
        {
            int cashSum = cash1 + cash2;

            switch (trueOrFalse)
            {
                case true:
                    return $"${cashSum} dollar";
                default:
                    return $"${cashSum} dollars";
            }
        }

        static int TryParseLoop_Int()
        {
            var canParse = int.TryParse(Console.ReadLine(), out var integer);

            while (!canParse)
            {
                Console.WriteLine("Please, type an integer.");
                canParse = int.TryParse(Console.ReadLine(), out integer);
            }
            return integer;
        }

        static decimal TryParseLoop_Decimal()
        {
            var canParse = decimal.TryParse(Console.ReadLine(), out var dec);

            while (!canParse)
            {
                Console.WriteLine("Please, type a decimal.");
                canParse = decimal.TryParse(Console.ReadLine(), out dec);
            }
            return dec;
        }
    }
}
