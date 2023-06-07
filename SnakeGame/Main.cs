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
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			this.MaximizeBox = false;
		}

		private void btnFacil_Click(object sender, EventArgs e)
		{
			Game game = new Game(0);
			game.Show();
			this.Hide();
		}

		private void btnNormal_Click(object sender, EventArgs e)
		{
			Game game = new Game(1);
			game.Show();
			this.Hide();
		}

		private void btnDificil_Click(object sender, EventArgs e)
		{
			Game game = new Game(2);
			game.Show();
			this.Hide();
		}

		private void btnImpossible_Click(object sender, EventArgs e)
		{
			Game game = new Game(3);
			game.Show();
			this.Hide();
		}

		private void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}