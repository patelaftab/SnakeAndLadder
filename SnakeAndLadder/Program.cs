﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder Program");
            SnakeLadder.snakeladderProgram();
            SnakeLadder.diceoutput();
            SnakeLadder.Play();
            Console.WriteLine(Console.ReadLine());
        }
    }
}
