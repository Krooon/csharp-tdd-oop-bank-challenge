using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Interfaces
{
    public interface IBankStatement
    {
        DateTime Date { get; set; }
        decimal Amount { get; set; }
        decimal OldBalance { get; set; }
        decimal NewBalance { get; set; }

    }
}
