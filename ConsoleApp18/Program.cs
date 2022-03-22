using System;

namespace ConsoleApp18
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            IPrintInfo _info = GetPrintInfo();

            Console.WriteLine(_info.Print()); /// представились 

            IMove _move = GetMove();
            Console.WriteLine(_move.Move(10));

            IAtack _atack = GetAtack();

            if( _atack != null )
            {
                Console.WriteLine(_atack.Atack());
            }

        }

        /// <summary>
        /// зависимости
        /// </summary>
        /// <returns></returns>
        private static IAtack GetAtack()
        {
            return new Animal();
        }

        private static IMove GetMove()
        {
            return new Animal();
        }

        private static IPrintInfo GetPrintInfo()
        {
            return new Animal();
        }
    }
}
