using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeShaftEngine.Math
{
	public struct Vector2f
	{
		float X { get; set; }
		float Y { get; set; }

		public Vector2f()
		{
			X = 0;
			Y = 0;
		}

		public Vector2f(float X, float Y)
		{
			this.X = X;
			this.Y = Y;
		}

		public Vector2f operator +(Vector2f a, Vector2f b)
		{
			return new Vector2f(a.X + b.X, a.Y + b.Y);
		}
	}
}
