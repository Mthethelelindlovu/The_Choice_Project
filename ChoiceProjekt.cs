/// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        

        // prompting the user to enter an integer
        Console.WriteLine("Enter a positive integer that is less than or equal to 15: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0 && number <= 15)
        {

            Console.WriteLine(" To proceed enter the choice, either 1 or 2 or 3");
            // prompting the user to enter the choice when a valid integer has been entered
            Console.WriteLine();
            Console.WriteLine("The entered choice is: ");
           
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                //option 1 that displays first five multiples and the sum of the entered number
                case 1:
                    // calculating the first five multiples of the entered number
                    Console.WriteLine("The first five multiples of the number entered are: ");
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine(number * i);

                    }
                    int total = 0;
                    // calculating the sum of the multiples 
                    for (int j = 1; j < 6; j++)
                    {
                        total = total + number * j;

                    }
                    Console.WriteLine("The total of the first five multiples of the entered number is: " + total);
                    break;
                // option 2 displays all consecutive numbers up to the entered number
                case 2:
                    Console.Write("The positive consecutive numbers up to the number are: ");
                    for (int y = 1; y <= number; y++)
                    {
                        Console.WriteLine(y);

                    }
                    break;

                case 3:
                    // option 3 displays the factorial of the chosen number
                    Console.Write("The factorial of the chosen number is: ");
                    long fact =1;
                    for (int x = 1; x <= number; x++)
                    {
                        fact = fact * x;

                    }
                    Console.WriteLine(fact);
                    break;

                default:
                    // a message dispalyed when an invaild option is entered
                    Console.WriteLine("Invalid option, options are 1, 2 or 3");
                    break;
            }

        }
        // an alert message dispalyed when an invalid number is entered
        else Console.WriteLine("You have entered an incorrect or invalid number!!");

    }


}
   

    


