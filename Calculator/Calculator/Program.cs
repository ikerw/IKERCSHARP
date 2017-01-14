using System;

namespace Calculator
{

	class Program
	{
		public static void Main(string[] args)
		{
			Calculator calculator = new Calculator();

			Console.WriteLine("Please enter the first number");
			double num_1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the second number");
			double num_2 = double.Parse(Console.ReadLine());

			Console.WriteLine("Need a third number? (yes/no)");
			string option_1 = Console.ReadLine();
			if (option_1 == "yes")
			{
				Console.WriteLine("Please enter the third number");
				double num_3 = double.Parse(Console.ReadLine());

				Console.WriteLine("Please select an option from below");
				Console.WriteLine("a. + ");
				Console.WriteLine("b. - ");
				Console.WriteLine("c. * ");
				Console.WriteLine("d. / ");

				string option_2 = Console.ReadLine();

				if (option_2 == "a")
				{
					Console.WriteLine(calculator.Add(num_1, num_2, num_3));
				}
				else if (option_2 == "b")
				{
					Console.WriteLine(calculator.Subtraction(num_1, num_2, num_3));
				}
				else if (option_2 == "c")
				{
					Console.WriteLine(calculator.Times(num_1, num_2, num_3));
				}
				else if (option_2 == "d")
				{
					Console.WriteLine(calculator.Division(num_1, num_2, num_3));
				}
			}
			else 
			{
				Console.WriteLine("Please select an option from below");
				Console.WriteLine("a. + ");
				Console.WriteLine("b. - ");
				Console.WriteLine("c. * ");
				Console.WriteLine("d. / ");

				string option_2 = Console.ReadLine();

				if (option_2 == "a")
				{
					Console.WriteLine(calculator.Add(num_1, num_2));
				}
				else if (option_2 == "b")
				{
					Console.WriteLine(calculator.Subtraction(num_1, num_2));
				}
				else if (option_2 == "c")
				{
					Console.WriteLine(calculator.Times(num_1, num_2));
				}
				else if (option_2 == "d")
				{
					Console.WriteLine(calculator.Division(num_1, num_2));
				}
			}
		}
	}

	class Calculator
	{
		// Add
		public int Add(int num_1, int num_2)
		{
			int addition = num_1 + num_2;
			return addition;
		}

		public double Add(double num_1, double num_2)
		{
			double addition = num_1 + num_2;
			return addition;
		}

		public double Add(int num_1, double num_2)
		{
			double addition = num_1 + num_2;
			return addition;
		}

		public int Add(int num_1, int num_2, int num_3)
		{
			int addition = num_1 + num_2 + num_3;
			return addition;
		}

		public double Add(double num_1, double num_2, double num_3)
		{
			double addition = num_1 + num_2 + num_3;
			return addition;
		}

		// Multiplication
		public int Times(int num_1, int num_2)
		{
			int multiplication = num_1 * num_2;
			return multiplication;
		}

		public double Times(double num_1, double num_2)
		{
			double multiplication = num_1 * num_2;
			return multiplication;
		}

		public double Times(int num_1, double num_2)
		{
			double multiplication = num_1 * num_2;
			return multiplication;
		}

		public int Times(int num_1, int num_2, int num_3)
		{
			int multiplication = num_1 * num_2 * num_3;
			return multiplication;
		}

		public double Times(double num_1, double num_2, double num_3)
		{
			double multiplication = num_1 * num_2 * num_3;
			return multiplication;
		}

		// subtraction
		public int Subtraction(int num_1, int num_2)
		{
			int Subtract = num_1 - num_2;
			return Subtract;
		}

		public double Subtraction(double num_1, double num_2)
		{
			double Subtract = num_1 - num_2;
			return Subtract;
		}

		public double Subtraction(int num_1, double num_2)
		{
			double Subtract = num_1 - num_2;
			return Subtract;
		}

		public int Subtraction(int num_1, int num_2, int num_3)
		{
			int Subtract = num_1 - num_2 - num_3;
			return Subtract;
		}

		public double Subtraction(double num_1, double num_2, double num_3)
		{
			double Subtract = num_1 - num_2 - num_3;
			return Subtract;
		}

		// division
		public int Division(int num_1, int num_2)
		{
			int Divide = num_1 / num_2;
			return Divide;
		}

		public double Division(double num_1, double num_2)
		{
			double Divide = num_1 / num_2;
			return Divide;
		}

		public double Division(int num_1, double num_2)
		{
			double Divide = num_1 / num_2;
			return Divide;
		}

		public int Division(int num_1, int num_2, int num_3)
		{
			int Divide = num_1 / num_2 / num_3;
			return Divide;
		}

		public double Division(double num_1, double num_2, double num_3)
		{
			double Divide = num_1 / num_2 / num_3;
			return Divide;
		}

	}


}
