using System;
using System.Collections.Generic;
using System.Text;

namespace Schreibtools
{
	class Kugelschreiber : Stift
	{
		public Kugelschreiber(double strichstaerke, ConsoleColor farbe) : base(strichstaerke, farbe)
		{
			Typ = "Kugelschreiber";
		}
	}
}
