using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
	public partial class Game : Form
	{
		String[,] mapa = new String[15, 15];
		List<SnakePos> pos = new List<SnakePos>();
		List<Food> food = new List<Food>();
		Timer timer = new Timer();
		Snake snake = new Snake();
		Random rnd = new Random();
		Boolean choque = false;
		public Game(int lvl)
		{
			InitializeComponent();
			Emplenar(ref mapa);
			pos.Add(new SnakePos(0, 7));
			pos.Add(new SnakePos(1, 7));
			pos.Add(new SnakePos(2, 7));
			Actualitzar(ref mapa, pos, food);
			txMapa.Text = Imprimir(mapa);
			Fnc.TxAutoResize(txMapa);
			txMapa.Height += 20;
			txMapa.Enabled = false;
			int cont = 0;
			switch (lvl)
			{
				case 0:
					timer.Interval = 300;
					break;
				case 1:
					timer.Interval = 200;
					break;
				case 2:
					timer.Interval = 100;
					break;
				case 3:
					timer.Interval = 50;
					break;
				default: break;
			}
			timer.Start();
			timer.Tick += (s, ev) =>
			{
				cont++;
				int y = pos[pos.Count - 1].Y;
				int x = pos[pos.Count - 1].X;
				switch (snake.Direccion)
				{
					case 'W':
						if (y != 0)
						{
							pos.Add(new SnakePos(y - 1, x));
							pos.RemoveAt(0);
							if (mapa[y - 1, x] == "S") choque = true;
						}
						else choque = true;
						break;
					case 'S':
						if (y + 1 != mapa.GetLength(1))
						{
							pos.Add(new SnakePos(y + 1, x));
							pos.RemoveAt(0);
							if (mapa[y + 1, x] == "S") choque = true;
						}
						else choque = true;
						break;
					case 'A':
						if (x != 0)
						{
							pos.Add(new SnakePos(y, x - 1));
							pos.RemoveAt(0);
							if (mapa[y, x - 1] == "S") choque = true;
						}
						else choque = true;
						break;
					case 'D':
						if (x + 1 != mapa.GetLength(0))
						{
							pos.Add(new SnakePos(y, x + 1));
							pos.RemoveAt(0);
							if (mapa[y, x + 1] == "S") choque = true;
						}
						else choque = true;
						break;
					default:
						break;
				}
				int yTmp = pos[pos.Count - 1].Y;
				int xTmp = pos[pos.Count - 1].X;
				if (mapa[yTmp, xTmp] == "O")
				{
					food.RemoveAll(o => o.X == xTmp && o.Y == yTmp);
					pos.Add(new SnakePos(yTmp, xTmp));
				}
				if (cont % 10 == 0)
				{
					if (food.Count < 3)
						food.Add(new Food(rnd, mapa));
				}
				Emplenar(ref mapa);
				try
				{
					Actualitzar(ref mapa, pos, food);
					txMapa.Text = Imprimir(mapa);
				}
				catch
				{
					timer.Stop();
					MessageBox.Show("GAME OVER");
					Tancar();
				}
				if (choque)
				{
					timer.Stop();
					MessageBox.Show("GAME OVER");
					Tancar();
				}
			};
			this.Size = new Size(0, 0);
			this.AutoSize = true;
			this.Padding = new Padding(10);
			this.MaximizeBox = false;
		}
		private void Emplenar(ref String[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					array[i, j] = ".";
				}
			}
		}
		private String Imprimir(String[,] array)
		{
			String result = "";
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					result += array[i, j] + " ";
				}
				result = result.Substring(0, result.Length - 1);
				result += Environment.NewLine;
			}
			result = result.Substring(0, result.Length - 2);
			return result;
		}
		private void Actualitzar(ref String[,] array, List<SnakePos> pos, List<Food> food)
		{
			foreach (var item in pos)
			{
				array[item.Y, item.X] = "S";
			}
			foreach (var item in food)
			{
				array[item.Y, item.X] = "O";
			}
		}
		private void Game_KeyDown(object sender, KeyEventArgs e)
		{
			int yPen = pos[pos.Count - 2].Y;
			int xPen = pos[pos.Count - 2].X;
			int yUlt = pos[pos.Count - 1].Y;
			int xUlt = pos[pos.Count - 1].X;
			switch (e.KeyCode)
			{
				case Keys.W:
					if (xPen != xUlt || (xPen == xUlt && yPen == yUlt))
						snake.Direccion = 'W';
					break;
				case Keys.Up:
					if (xPen != xUlt || (xPen == xUlt && yPen == yUlt))
						snake.Direccion = 'W';
					break;

				case Keys.S:
					if (xPen != xUlt || (xPen == xUlt && yPen == yUlt))
						snake.Direccion = 'S';
					break;
				case Keys.Down:
					if (xPen != xUlt || (xPen == xUlt && yPen == yUlt))
						snake.Direccion = 'S';
					break;

				case Keys.A:
					if (yPen != yUlt || (xPen == xUlt && yPen == yUlt))
						snake.Direccion = 'A';
					break;
				case Keys.Left:
					if (yPen != yUlt || (xPen == xUlt && yPen == yUlt))
						snake.Direccion = 'A';
					break;

				case Keys.D:
					if (yPen != yUlt || (xPen == xUlt && yPen == yUlt))
						snake.Direccion = 'D';
					break;
				case Keys.Right:
					if (yPen != yUlt || (xPen == xUlt && yPen == yUlt))
						snake.Direccion = 'D';
					break;

				default:
					break;
			}
		}
		private void Tancar()
		{
			timer.Stop();
			Main main = (Main)Application.OpenForms["Main"];
			main.Show();
			this.Hide();
		}

		private void Game_FormClosed(object sender, FormClosedEventArgs e)
		{
			timer.Stop();
			Main main = (Main)Application.OpenForms["Main"];
			if (main == null)
			{
				main = new Main();
			}
			main.Show();
		}
	}
}