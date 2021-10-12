using System;

namespace MathApp
{
    enum Operation
    {
        roundUp,
        roundDown,
        getSquareRoot,
        getCubeRoot,
        getBase10Log,
    }

    class MathProgram
    {
        public static void Main(string[] args)
        {
            getUserInput();
        }

        private static void getUserInput()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter a number:");
            String input = Console.ReadLine();
            double numberInput;

            if (double.TryParse(input, out numberInput)) pickOperation(numberInput);
            else
            {
                Console.WriteLine("That's not a number");
                getUserInput();
            }
        }

        private static void pickOperation(double num)
        {
            Console.WriteLine("");
            Console.WriteLine("What would you like to do with this number: " + num);

            foreach (int i in Enum.GetValues(typeof(Operation)))
                Console.WriteLine($"{i}. {Enum.GetName(typeof(Operation), i)}");

            int enumMaxCount = Enum.GetValues(typeof(Operation)).Length - 1;
            Console.WriteLine($"Pick from 0-{enumMaxCount}, (Whole numbers only)");

            String input = Console.ReadLine();
            int operationIndex;

            if (int.TryParse(input, out operationIndex) && operationIndex <= 4 && operationIndex >= 0) runOperation(operationIndex, num);
            else
            {
                Console.WriteLine($"That's not a whole number from 1-{enumMaxCount}");
                pickOperation(num);
            }
        }

        private static void runOperation(int operationIndex, double num)
        {
            Console.WriteLine("\nANSWER:");
            switch ((Operation)(operationIndex))
            {
                case Operation.roundUp:
                    Console.WriteLine(roundUp(num));
                    break;
                case Operation.roundDown:
                    Console.WriteLine(roundDown(num));
                    break;
                case Operation.getSquareRoot:
                    Console.WriteLine(getSquareRoot(num));
                    break;
                case Operation.getCubeRoot:
                    Console.WriteLine(getCubeRoot(num));
                    break;
                case Operation.getBase10Log:
                    Console.WriteLine(getBase10Log(num));
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Done\n");
            startAgainPrompt();
        }

        private static void startAgainPrompt()
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to start again? y/n");
            String response = Console.ReadLine();
            if (response.ToLower() == "y") getUserInput();
            else if (response.ToLower() == "n") Console.WriteLine("Okay bye");
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Answer with y or n only");
                startAgainPrompt();
            }
        }

        private static double roundUp(double num) => Math.Ceiling(num);
        private static double roundDown(double num) => Math.Floor(num);
        private static double getSquareRoot(double num) => Math.Sqrt(num);
        private static double getCubeRoot(double num) => Math.Cbrt(num);
        private static String getBase10Log(double num) => num >= 0 ? Math.Log10(num).ToString() : "cannot perform operation, Logarithm of negative numbers doesn't exist in real space or in complex space";
    }
}
