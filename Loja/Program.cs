﻿using Loja.Infra;
using System;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {

            NHibernateHelper.GeraSchema();
            Console.Read();
        }
    }
}
