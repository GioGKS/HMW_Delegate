using System;

namespace HMW_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
         
            SimpleCalculator Simple = new SimpleCalculator();
            AtomicCalculator Atom = new AtomicCalculator();
            Atom.GetUserChoice = Simple.GetUserChoice;
            Atom.GetNumberFromUser = Simple.NumberGetter;
            Atom.MenuPrinter = Simple.PrintMenu;
            Atom.Calculate = Simple.Calculate;
            Atom.Resultprinter = Simple.PrintResultNicely;
            Atom.Run();

        }
    }
}
