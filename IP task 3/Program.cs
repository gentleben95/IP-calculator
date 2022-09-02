namespace IP_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, I am calculator. Use me!");
            Console.WriteLine("---------------");
            Console.Write("First number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            // Próbowałem z TryParse zrobić, jeżeli w number1 ktos nie wpisze liczby, to wyswietli tekst "Numbers only! Try again: "
            // ale poległem, bo jak w if dawałem { double number1 = Convert.ToDouble(Console.ReadLine()); } to wtedy dolne ify z operatorora nie pobieraly number1 variable
            Console.WriteLine("---------------");
            Console.WriteLine("Operators: Add (+), Subtract (-), Multiply (*), Divide (/)"); // Tutaj zapomnialem jak zrobić żeby każdy z operators był wypisany w osobnym wierszu, żeby nie wpisywac 4 razy Console.WriteLine
            Console.WriteLine("---------------");
            Console.Write("Choose operator: ");
            string op = Console.ReadLine();
            Console.WriteLine("---------------");
            Console.Write("Second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // jezeli ktoś otrzyma wynik lub da invalid operator, to jak zrobić żeby mógł używać kalkulatora ponownie, nie otwierając go ponownie?



            if (op == "+")
            {
                Console.WriteLine("---------------");
                Console.WriteLine("The result is: " + (number1 + number2));
            }
            else if (op == "-")
            {
                Console.WriteLine("---------------");
                Console.WriteLine("The result is: " + (number1 - number2));
            }
            else if (op == "*")
            {
                Console.WriteLine("---------------");
                Console.WriteLine("The result is: " + (number1 * number2));
            }
            else if (op == "/")
            {
                Console.WriteLine("---------------");
                Console.WriteLine("The result is: " + (number1 / number2));
                
            }
            
            else
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Invalid operator");
            }
            Console.ReadLine();

        }

    }
}