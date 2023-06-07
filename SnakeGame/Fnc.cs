using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
	static class Fnc
	{
		public static void TxAutoResize(TextBox textBox)
		{
			textBox.Multiline = true;
			textBox.MinimumSize = new Size(0, 0);
			textBox.Size = TextRenderer.MeasureText(textBox.Text, textBox.Font);
		}
		public static void Shuffle<T> (this Random rng, T[] array)
    	{
        	int n = array.Length;
        	while (n > 1) 
        	{
            	int k = rng.Next(n--);
            	T temp = array[n];
            	array[n] = array[k];
            	array[k] = temp;
        	}
    	}
	}
}