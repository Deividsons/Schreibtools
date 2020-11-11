using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Schreibtools
{
	class Program
	{
		static void Main(string[] args)
		{
            string testtext = "Hallo 3CHIT!";
            List<Stift> testlist = new List<Stift>();
            testlist.Add(new Kugelschreiber(3, ConsoleColor.Black));
            testlist.Add(new Kugelschreiber(2, ConsoleColor.Red));
            testlist.Add(new Buntstift(3, ConsoleColor.Blue));
            testlist.Add(new Buntstift(2, ConsoleColor.White));
            foreach (Stift i in testlist)
            {
                i.SchreibeText(testtext);
            }
            Console.ReadKey();
        }
	}
	
}
