using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11.Interfaces
{
	internal interface IDemegable
	{
		public int HP { get; set; }

		public void Demeg(int demage)
		{
			HP -= demage;
		}
	}
}
