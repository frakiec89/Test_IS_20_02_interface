using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal interface IMove
    {
        string Move(int second);
    }

    partial interface IAtack
    {
        string Atack();
    }


    interface IPrintInfo
    {
        string Print();
    }
}
