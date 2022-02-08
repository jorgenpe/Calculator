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
                        break;
                        }
                        
                   case 2:
                        {
                            Sub();
                        break;
                        }
                    case 3:
                        {
                            Multi();
                        break;
                        }
                    case 4: 
                        {
                            Div();
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

                Console.WriteLine("Choice what mathematical operation you want to preform.");
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
                
            } 

            static void Sub() { }

            static void Multi() { }

            static void Div() { }    





        }
    }
}
