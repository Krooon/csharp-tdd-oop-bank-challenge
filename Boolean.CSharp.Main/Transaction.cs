﻿using Boolean.CSharp.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Transaction : IBankStatement
    {
        public DateTime Date { get; set; }
        public decimal OldBalance { get; set; }
        public decimal Amount { get; set; }
        
        public decimal NewBalance { get; set; }

        public Transaction(DateTime Date, decimal OldBalance, decimal Amount, decimal NewBalance)
        {
            this.Date = Date;
            this.Amount = Amount;
            this.OldBalance = OldBalance;
            this.NewBalance = NewBalance;
        }

    }
}
