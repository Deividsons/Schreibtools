using System;
using System.Collections.Generic;
using System.Text;

namespace Schreibtools
{
	abstract class Stift
	{
		public double Strichstaercke { get; set; }
		public ConsoleColor Farbe { get; set; }
		public string Typ { get; set; }

		public Stift(double strichstaerke)
		{
			Strichstaercke = strichstaerke;
			Typ = "unbekannt";
			Farbe = ConsoleColor.Blue;
		}
		public Stift(double strichstaerke, ConsoleColor farbe) : this(strichstaerke)
		{
			Farbe = farbe;
		}
	}
}
