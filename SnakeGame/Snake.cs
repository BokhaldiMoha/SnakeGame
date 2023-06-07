using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
	internal class Snake
	{
		private int longitud;
		private char direccion;
		public Snake()
		{
			this.longitud = 3;
			this.direccion= 'S';
		}
		public int Longitud { get { return longitud; } set { longitud = value; } }
		public char Direccion { get { return direccion; } set { direccion = value; } }
	}
}