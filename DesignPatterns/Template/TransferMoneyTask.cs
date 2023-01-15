﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public class TransferMoneyTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Transfer Money");
        }
    }
}
