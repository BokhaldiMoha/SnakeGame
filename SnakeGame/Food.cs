using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
	internal class Food
	{
		private int y;
		private int x;
		public Food(Random rnd, String[,] array)
		{
			do
			{
				this.y = rnd.Next(array.GetLength(0));
				this.x = rnd.Next(array.GetLength(1));
			}
			while (array[this.y,this.x] == "S" || array[this.y, this.x] == "O");
		}
		public int Y { get { return this.y;} }
		public int X { get { return this.x;} }
	}
}