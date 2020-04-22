using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using static System.Math;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temp = Console.ReadLine(); // a tempterature in range
       
        int[] tInputs = new int[n];
        
        
        if (n == 0)
        {
            Console.WriteLine("0");
        }
        //большое разветвление
        else 
        {
            //каждую введённую температуру разделяет пробелом и ставит в массив
            tInputs = temp.Split(' ').Select(s => int.Parse(s)).ToArray();
            int bestTemp = 5527;
            
  //просто код, который проверяет условия (в задании описан уже в принципе концепт работы)
            for (int i = 0; i < n; i++)
            {
                
                if (temp == "0")
                {
                    Console.WriteLine("0");
                }
                else if (Math.Abs(tInputs[i]) < Math.Abs(bestTemp))
                {
                    bestTemp = tInputs[i];
                }
                else if (Math.Abs(tInputs[i]) == Math.Abs(bestTemp) && tInputs[i] > bestTemp)
                {
                    bestTemp = tInputs[i];
                }
                
            }
            
            Console.WriteLine(bestTemp);
            Console.Error.WriteLine("Debug messages...");
            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            
            //Console.WriteLine("result");
            }
    }
}
