using System;
namespace HMW_Delegate
{
    public class AtomicCalculator
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public AtomicCalculator()
        {
        }

        public Func<int> GetNumberFromUser { get; set; }
        public Action MenuPrinter { get; set; }
        public Func<int> GetUserChoice { get; set; }
        public Func<int, int, int, int> Calculate { get; set; }
        public Action<double> Resultprinter { get; set; }
        

        public AtomicCalculator(Func<int> getNumberFromUser, Action menuPrinter, Func<int> getUserChoice,
            Func<int, int, int, int> calculate, Action<double> resultprinter)
        {
            GetNumberFromUser += getNumberFromUser;
            MenuPrinter += menuPrinter;
            GetUserChoice += getUserChoice;
            Calculate += calculate;
            Resultprinter += resultprinter;
        }

        public void Run()
        {
            X = GetNumberFromUser();
            Y = GetNumberFromUser();
            MenuPrinter();
            int userchoice = GetUserChoice();
            int result = (int)Calculate(X, Y, userchoice);
            Resultprinter(result);

        }
    }
}
