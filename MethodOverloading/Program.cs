namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first method adds two integers.\nPlease, type the first integer.");
            int integer1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, type the second integer.");
            int integer2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of {integer1} and {integer2} is {Add(integer1, integer2)}.");
            
            Console.WriteLine("\nThe second method adds two decimals.\nPlease, type the first decimal.");
            decimal decimal1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please, type the second decimal.");
            decimal decimal2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"The sume of  {decimal1} and {decimal2} is {Add(decimal1, decimal2)}.");

            Console.WriteLine("\nThe third method counts dollar bills!");
            Console.WriteLine("Please, count the number of dollar bills in the safe or count the number of dollar bills missing from the safe.");
            Console.WriteLine("Type a positive integer when bills are on hand.");
            Console.WriteLine("Type zero when the safe is flawlessly empty.");
            Console.WriteLine("Type a negative integer when counting the number of bills missing from the safe.");
            int cash1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, count the number of dollar bills in the cash drawer or missing from the cash drawer.");
            int cash2 = int.Parse(Console.ReadLine());
            
            //if (cash1 == cash2)
            //{
            //    bool grammar = true;
            //}
            //else
            //{
            //    bool grammar = false;
            //}

            Console.WriteLine("True or False, The sum of the bills is a dollar?\nPlease, type true or false.");
            bool grammar = bool.Parse(Console.ReadLine());
            Console.WriteLine($"{Add(cash1, cash2, grammar)}.");
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

        static string Add(int cash1, int cash2, bool grammar)
        {
            int cashSum = cash1 + cash2;

            switch (grammar)
            {
                case true:
                    return $"${cashSum} dollar";
                default:
                    return $"${cashSum} dollars";
            }
            //if (integerSum == 1)
            //{
            //    return $"${integerSum} dollar";
            //}
            //else
            //{
            //    return $"${integerSum} dollars";
            //}
        }
    }
}
