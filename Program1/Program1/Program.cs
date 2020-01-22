using System;

namespace Program1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Boolean keepGoing = true;
            int chosenNumber = -1;
            Console.WriteLine("Pick a number between 3 and 9");
            while (keepGoing == true)
            {
          
                chosenNumber = Convert.ToInt32(Console.ReadLine());
                if (chosenNumber <= 9 && chosenNumber >= 3)
                {
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Enter a number between 3 and 9");
                }

            }

            Console.WriteLine("Normal times table for what you wrote:");

            for (int i = 1; i<= chosenNumber; i++)
            {
                for(int j = 1; j<= chosenNumber; j++)
                {
                    Console.Write(j * i + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Flip on 1) Horizon, 2) Vertical, 3) Diagonal Left, 4) Diagonal Right, 5) To End:");
            keepGoing = true;
            int flipNum = -1;
            while (keepGoing == true)
            {
                Boolean isNumber = int.TryParse(Console.ReadLine(), out flipNum);
                if (isNumber == true && flipNum <= 5 && flipNum >= 1)
                {
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Enter a number between 1 and 5 for: Flip on 1) Horizon, 2) Vertical, 3) Diagonal Left, 4) Diagonal Right, 5) To End:");
                }

            }
            Console.WriteLine(chosenNumber);
            if (flipNum == 1)
            {
                //horizontal
                for (int i = 1; i <= chosenNumber; i++)
                {
                    for (int j = chosenNumber; j >= 1; j--)
                    {
                        Console.Write(j * i + " ");
                    }
                    Console.WriteLine();
                }
            }
            else if(flipNum == 2)
            {
                //verticle
                for (int i = chosenNumber; i >= 1; i--)
                {
                    for (int j = 1; j <= chosenNumber; j++)
                    {
                        Console.Write(j * i + " ");
                    }
                    Console.WriteLine();
                }
            }
            else if (flipNum == 3)
            {
                //diagonal left
                for (int i = chosenNumber; i >= 1; i--)
                {
                    for (int j = chosenNumber; j >= 1; j--)
                    {
                        Console.Write(j * i + " ");
                    }
                    Console.WriteLine();
                }
            }else if(flipNum == 4)
            {
                //diagonal right (Same as normal)
                for (int i = 1; i <= chosenNumber; i++)
                {
                    for (int j = 1; j <= chosenNumber; j++)
                    {
                        Console.Write(j * i + " ");
                    }
                    Console.WriteLine();
                }
            } 
            Console.ReadLine();
        }

    }
}

/*
Program #1

Asks user the the number between 3 and 9
Create a times table using that number
Output a menu "Flip on 1) Horizon, 2) Vertical, 3) Diagonal Left, 4) Diagonal Right, 5) To End: "
Based upon selection, output the table with the new orientation, followed by the menu unless 5 is selected.
Please Enter a Number between 3 and 9: 5

1 2 3 4 5
2 4 6 8 10
3 6 9 12 15
4 8 12 16 20
5 10 15 20 25

Flip on 1) Horizon, 2) Vertical, 3) Diagonal Left, 4) Diagonal Right, 5) To End: 1

5 10 15 20 25
4 8 12 16 20
3 6 9 12 15
2 4 6 8 10
1 2 3 4 5

Flip on 1) Horizon, 2) Vertical, 3) Diagonal Left, 4) Diagonal Right, 5) To End: 5
*/