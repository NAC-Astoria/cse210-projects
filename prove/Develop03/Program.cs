using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference script1_ref = new Reference("John", 3, 16);
        string script1_text = "For God so loved the world...";        
        Scripture script1 = new Scripture(script1_ref, script1_text);

        script1.DisplayText();

        Reference script2_ref = new Reference("Proverbs", 3, 5, 6);
        string script2_text = "Trust in the Lord... ...your paths straight.";        
        Scripture script2 = new Scripture(script2_ref, script2_text);

        script2.DisplayText();

        Console.Write("Hit Enter to quit.");
        Console.ReadLine();
        Console.Clear();
    }
}