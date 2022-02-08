using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool choice = true;

            while (choice)
            {
                Console.Clear();    
                int calculatorChoice = menu();

                switch (calculatorChoice)
                {
                    case 1:
                        { 
                            Add();
                            Console.ReadKey();
                        break;
                        }
                        
                   case 2:
                        {
                            Sub();
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Multi();
                            Console.ReadKey();
                            break;
                        }
                    case 4: 
                        {
                            Div();
                            Console.ReadKey();
                            break;
                        }
                    case 9:
                        {
                            choice = false;
                            break;
                        }
                        

                }


            }

            static int menu()
            {
                string count = "0";

                Console.WriteLine("Choice what mathematical operation you want to preform:");
                Console.WriteLine("1. Addition.");
                Console.WriteLine("2. Subtraction.");
                Console.WriteLine("3. Multiplcation.");
                Console.WriteLine("4. Divide.");
                Console.WriteLine("9. Exit");
                count = Console.ReadLine();
             
                return Convert.ToInt32(count);

            }

            static void Add()
            {

                Console.Clear();
                Console.Write("Please state the first number: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please state the second number: ");
                double secondNum =Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The sum is: " + (firstNum + secondNum));
                Console.WriteLine(" Stroke any key to return to menu.");
                
            } 

            static void Sub() {
                Console.Clear();
                Console.Write("Please state the first number: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please state the second number: ");
                double secondNum = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The subtraction is: " + (firstNum - secondNum));
                Console.WriteLine(" Stroke any key to return to menu.");
            }

            static void Multi() {
                Console.Clear();
                Console.Write("Please state the first number: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Please state the second number: ");
                double secondNum = Convert.ToDouble(Console.ReadLine());
                       
                Console.WriteLine("The result of multiplication is: " + (firstNum * secondNum));
                Console.WriteLine(" Stroke any key to return to menu.");
            }

            static void Div() {

                Console.Clear();
                Console.Write("Please state the numerator: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());

                double secondNum = 0;

                while (secondNum == 0)
                {
                    Console.Write("Please state the denominator: ");
                    secondNum = Convert.ToDouble(Console.ReadLine());
                    if (secondNum == 0)
                    {
                        Console.WriteLine("The denominator can not be zero");
                    }

                }

                Console.WriteLine("The result of division is: " + (firstNum / secondNum));
                Console.WriteLine(" Stroke any key to return to menu.");
            }    





        }
    }
}
