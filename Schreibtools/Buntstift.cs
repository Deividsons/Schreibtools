using System;
using System.Collections.Generic;
using System.Text;

namespace Schreibtools
{
	class Buntstift : Stift
	{
		public Buntstift(double strichstaerke, ConsoleColor farbe) : base(strichstaerke, farbe)
		{
			Typ = "Buntstift";
		}
	}
}
