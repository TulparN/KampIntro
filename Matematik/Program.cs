﻿using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(2, 3);

            dortIslem.Topla(6,9);
            Console.ReadLine();
        }
    }
}