﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.Fill();
            operaciones.Robar();
        }
    }
}
