using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        while (quit == false)
        {
            string[] _options = {"Create new entry", "Dispaly journal", "Save journal", "Load journal"};

            
            Console.WriteLine("Please select one of the following");

            foreach (string _option in _options)
            {
                Console.WriteLine(_option);
            }


        }
    }
}