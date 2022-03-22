using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Piople : IPrintInfo, IMove
    {
        public string Move(int second)
        {
            return Print() + " - " + $"я  переместился на  {second * 10} метров";
        }

        public string Print()
        {
            return "Я человек ";
        }
    }



    public class Animal : IPrintInfo, IMove, IAtack
    {
        public string Atack()
        {
            return "Я всех съел ";
        }

        public string Move(int second)
        {
            return Print() + " - " + $"я  переместился на  {second * 100} метров";
        }

        public string Print()
        {
            return "Я гепард ";
        }
    }
}


