﻿using System;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CFB Cursos!");
            if(args.GetLength(0)){
                Console.WriteLine(args.GetValue(0));
            }
        }
    }
}
