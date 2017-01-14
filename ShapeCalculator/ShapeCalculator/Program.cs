using System;

namespace ShapeCalculator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			
			ShapeAreaCalculator shapeRec = new ShapeAreaCalculator(111.1,222.2);
			Console.WriteLine(shapeRec.GetRecArea());

			ShapeAreaCalculator shapeCir = new ShapeAreaCalculator(2.33);
			Console.WriteLine(shapeCir.GetCirArea());

		}
	}

}
