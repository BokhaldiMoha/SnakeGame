namespace SnakeGame
{
	partial class Game
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txMapa = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txMapa
			// 
			this.txMapa.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txMapa.Location = new System.Drawing.Point(13, 13);
			this.txMapa.Multiline = true;
			this.txMapa.Name = "txMapa";
			this.txMapa.Size = new System.Drawing.Size(164, 97);
			this.txMapa.TabIndex = 0;
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txMapa);
			this.Name = "Game";
			this.Text = "Snake Game";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txMapa;
	}
}

