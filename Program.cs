﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        static void Play(string sounds, int lim)
        {
            int k = 0;
            if (k == lim)
                return;

            var nums = sounds.Split(" \t\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Random rn = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    Thread.Sleep(100);
                }
                else
                {
                    Console.Beep((nums[i]), rn.Next(220, 250));
                  //  Console.Beep(nums[i] + (rn.Next(10, 20)), rn.Next(140, 180));
                    Thread.Sleep(rn.Next(260, 290));

                }
            }
            lim -= 1;
            Play(sounds, lim);
        }

        


        static void Main(string[] args)
        {
                string sound = " 0 439 348 439 348 329 348 329 293 ";

                Play(sound,6);

                Console.Read();

        }
    }
}
