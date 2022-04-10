using System;
namespace HMW_Delegate
{
    public class SimpleCalculator
    {

        public SimpleCalculator()
        {
        }

        //Methods
        public int NumberGetter()
        {
           Console.WriteLine("Please Enter Positive Number:");
            int numFromUser = Convert.ToInt32(Console.ReadLine());
            if (numFromUser > 0)
                Console.WriteLine($"Your Choosen Number Is: {numFromUser}");
            else
                NumberGetter();
            return numFromUser;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Menu:  1)+\t2)-\t3)*\t4)/");
        }

        public int GetUserChoice()
        {
            Console.WriteLine("Please choose number Between 1-4:");
            int numb = int.Parse(Console.ReadLine());
            if (numb > 0 && numb < 5)
                Console.WriteLine($"Thank You! Your Choosen number Is: {numb}");
            else
                GetUserChoice();
            return numb;

        }

        public int Calculate(int num1,int num2,int optionNumber)
        {
            switch (optionNumber)
            {
                case 1:
                    return num1 + num2;
                case 2:
                    return num1 - num2;
                case 3:
                    return num1 * num2;
                case 4:
                    return num1 / num2;
                default:
                    return 0;
            }
        }

        public void PrintResultNicely(double dNum)
        {
            Console.WriteLine($"* * * * > {dNum} < * * * * ");
        }
    }
}
