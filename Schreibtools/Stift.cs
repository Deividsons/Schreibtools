using System;
using System.Collections.Generic;
using System.Text;

namespace Schreibtools
{
	abstract class Stift
	{
        public double Strichstaerke { get; set; }
        public ConsoleColor Farbe { get; set; }
        public string Typ { get; set; }
        public Stift(double strichstaerke)
        {
            Strichstaerke = strichstaerke;
            Typ = "unbekannt";
            Farbe = ConsoleColor.Black;
        }
        public Stift(double strichstaerke, ConsoleColor farbe) : this(strichstaerke)
        {
            Farbe = farbe;

        }
        public virtual void SchreibeText(string text)
        {
            Console.ForegroundColor = Farbe;
            Console.WriteLine($"{Typ}, {Strichstaerke}mm,{Farbe}: {text}");
        }
    }
}
