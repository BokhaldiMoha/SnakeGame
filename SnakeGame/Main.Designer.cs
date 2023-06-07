namespace SnakeGame
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnFacil = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnDificil = new System.Windows.Forms.Button();
            this.btnImpossible = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFacil
            // 
            this.btnFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacil.Location = new System.Drawing.Point(16, 15);
            this.btnFacil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(187, 43);
            this.btnFacil.TabIndex = 0;
            this.btnFacil.Text = "FÁCIL";
            this.btnFacil.UseVisualStyleBackColor = true;
            this.btnFacil.Click += new System.EventHandler(this.btnFacil_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(213, 15);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(187, 43);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.Text = "NORMAL";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnDificil
            // 
            this.btnDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDificil.Location = new System.Drawing.Point(16, 65);
            this.btnDificil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDificil.Name = "btnDificil";
            this.btnDificil.Size = new System.Drawing.Size(187, 43);
            this.btnDificil.TabIndex = 2;
            this.btnDificil.Text = "DIFÍCIL";
            this.btnDificil.UseVisualStyleBackColor = true;
            this.btnDificil.Click += new System.EventHandler(this.btnDificil_Click);
            // 
            // btnImpossible
            // 
            this.btnImpossible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpossible.Location = new System.Drawing.Point(213, 65);
            this.btnImpossible.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImpossible.Name = "btnImpossible";
            this.btnImpossible.Size = new System.Drawing.Size(187, 43);
            this.btnImpossible.TabIndex = 3;
            this.btnImpossible.Text = "IMPOSIBLE";
            this.btnImpossible.UseVisualStyleBackColor = true;
            this.btnImpossible.Click += new System.EventHandler(this.btnImpossible_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 121);
            this.Controls.Add(this.btnImpossible);
            this.Controls.Add(this.btnDificil);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnFacil);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnFacil;
		private System.Windows.Forms.Button btnNormal;
		private System.Windows.Forms.Button btnDificil;
		private System.Windows.Forms.Button btnImpossible;
	}
}