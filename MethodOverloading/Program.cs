namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first method adds two integers.\nPlease, type the first integer.");
            var canParse1 = int.TryParse(Console.ReadLine(), out var integer1);

            while (!canParse1)
            {
                Console.WriteLine("Please, type an integer.");
                canParse1 = int.TryParse(Console.ReadLine(), out integer1);
            }

            Console.WriteLine("Please, type the second integer.");
            var canParse2 = int.TryParse(Console.ReadLine(), out var integer2);

            while (!canParse2)
            {
                Console.WriteLine("Please, type an integer.");
                canParse2 = int.TryParse(Console.ReadLine(), out integer2);
            }

            Console.WriteLine($"The sum of {integer1} and {integer2} is {Add(integer1, integer2)}.");
            
            Console.WriteLine("\nThe second method adds two decimals.\nPlease, type the first decimal.");
            var canParse3 = decimal.TryParse(Console.ReadLine(), out var decimal1);

            while (!canParse3)
            {
                Console.WriteLine("Please, type a decimal.");
                canParse3 = decimal.TryParse(Console.ReadLine(), out decimal1);
            }

            Console.WriteLine("Please, type the second decimal.");
            var canParse4 = decimal.TryParse(Console.ReadLine(), out var decimal2);

            while (!canParse4)
            {
                Console.WriteLine("Please, type a decimal.");
                canParse4 = decimal.TryParse(Console.ReadLine(), out decimal2);
            }

            Console.WriteLine($"The sume of  {decimal1} and {decimal2} is {Add(decimal1, decimal2)}.");

            Console.WriteLine("\nThe third method counts dollar bills!");
            Console.WriteLine("Please, count the number of dollar bills in the safe or count the number of dollar bills missing from the safe.");
            Console.WriteLine("Type a positive integer when bills are on hand.");
            Console.WriteLine("Type zero when the safe is flawlessly empty.");
            Console.WriteLine("Type a negative integer when counting the number of bills missing from the safe.");
            var canParse5 = int.TryParse(Console.ReadLine(), out var cash1);
            
            while (!canParse5)
            {
                Console.WriteLine("The number of bills is an integer.");
                canParse5 = int.TryParse(Console.ReadLine(), out cash1);
            }

            Console.WriteLine("Please, count the number of dollar bills in the cash drawer or missing from the cash drawer.");
            var canParse6 = int.TryParse(Console.ReadLine(), out var cash2);
            
            while (!canParse6)
            {
                Console.WriteLine("The number of bills is an integer.");
                canParse6 = int.TryParse(Console.ReadLine(), out cash2);
            }
            
            Console.WriteLine("True or False, The sum of the bills is a dollar?\nPlease, type true or false.");
            //bool trueOrFalse = bool.Parse(Console.ReadLine());
            //Console.WriteLine($"{Add(cash1, cash2, trueOrFalse)}.");
            string falseOrTrue = Console.ReadLine().ToLower();

            while (falseOrTrue != "true" && falseOrTrue != "false")
            {
                Console.WriteLine("Please, type 'true' or 'false'!");
                falseOrTrue = Console.ReadLine().ToLower();
            }
            
            bool trueOrFalse = bool.Parse(falseOrTrue);
            Console.WriteLine($"{Add(cash1, cash2, trueOrFalse)}.");
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
    }
}
