using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture12.Interfaces
{
	internal interface ICalc2
	{
		//int CountDistinct() -აბრუნებს კონტეინერში არსებული უნიკალური მნიშვნელობების რაოდენობას.
		//int EqualToValue(int valueToCompare) 

		int CountDistinct();
		int EqualToValue(int valueToCompare);
	}
}
