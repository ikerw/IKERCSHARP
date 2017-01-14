using System;
namespace ShapeCalculator
{
	public class ShapeAreaCalculator
	{
		private double _width;
		private double _height;
		private double _radius;

		public double Radius
		{
			get
			{
				return _radius;
			}

			set
			{
				_radius = value;
			}
		}

		public double Width
		{
			get
			{
				return _width;
			}

			set
			{
				_width = value;
			}
		}

		public double Height
		{
			get
			{
				return _height;
			}

			set
			{
				_height = value;
			}
		}

		public ShapeAreaCalculator(double width, double height)
		{
			_width = width;
			_height = height;
		}

		public ShapeAreaCalculator(double radius)
		{
			_radius = radius;
		}

		public double GetRecArea()
		{
			double area = _width * _height;
			return area;
		}

		public double GetCirArea()
		{
			double area = Math.PI * (Math.Pow(_radius, 2));
			return area;
		}
	}
}
