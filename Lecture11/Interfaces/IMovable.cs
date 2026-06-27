using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11.Interfaces
{
	internal interface IMovable
	{

		public void Move(int x, int y);


		public void Move(float x, float y)
		{
			Console.WriteLine("IMovable.Move(float x, float y)");
		}
	}
}
