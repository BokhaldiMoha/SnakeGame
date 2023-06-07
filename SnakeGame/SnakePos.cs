using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
	internal class SnakePos
	{
		private int x;
		private int y;
		public SnakePos(int y, int x)
		{
			this.y = y;
			this.x = x;
		}

		public int X { get { return x; } set { x = value; } }
		public int Y { get { return y; } set { y = value; } }
	}
}