namespace PacMan
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.FRojo = new System.Windows.Forms.PictureBox();
            this.FRosado = new System.Windows.Forms.PictureBox();
            this.Pacman = new System.Windows.Forms.PictureBox();
            this.Tile = new System.Windows.Forms.PictureBox();
            this.Cherry = new System.Windows.Forms.PictureBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LGO = new System.Windows.Forms.Label();
            this.wall2 = new System.Windows.Forms.PictureBox();
            this.wall3 = new System.Windows.Forms.PictureBox();
            this.wall4 = new System.Windows.Forms.PictureBox();
            this.wall1 = new System.Windows.Forms.PictureBox();
            this.BReiniciar = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRosado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            this.SuspendLayout();
            // 
            // FRojo
            // 
            this.FRojo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FRojo.Image = global::PacMan.Properties.Resources.red_left1;
            this.FRojo.Location = new System.Drawing.Point(218, 446);
            this.FRojo.Name = "FRojo";
            this.FRojo.Size = new System.Drawing.Size(36, 38);
            this.FRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FRojo.TabIndex = 4;
            this.FRojo.TabStop = false;
            this.FRojo.Tag = "fan1";
            // 
            // FRosado
            // 
            this.FRosado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FRosado.Image = global::PacMan.Properties.Resources.pink_left1;
            this.FRosado.Location = new System.Drawing.Point(260, 446);
            this.FRosado.Name = "FRosado";
            this.FRosado.Size = new System.Drawing.Size(36, 38);
            this.FRosado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FRosado.TabIndex = 5;
            this.FRosado.TabStop = false;
            this.FRosado.Tag = "fan1";
            // 
            // Pacman
            // 
            this.Pacman.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pacman.Image = global::PacMan.Properties.Resources.pacman_right;
            this.Pacman.Location = new System.Drawing.Point(358, 229);
            this.Pacman.Name = "Pacman";
            this.Pacman.Size = new System.Drawing.Size(40, 40);
            this.Pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pacman.TabIndex = 6;
            this.Pacman.TabStop = false;
            this.Pacman.Tag = "fan1";
            // 
            // Tile
            // 
            this.Tile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tile.Image = global::PacMan.Properties.Resources.tile114;
            this.Tile.Location = new System.Drawing.Point(302, 464);
            this.Tile.Name = "Tile";
            this.Tile.Size = new System.Drawing.Size(20, 20);
            this.Tile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tile.TabIndex = 7;
            this.Tile.TabStop = false;
            this.Tile.Tag = "Tile";
            // 
            // Cherry
            // 
            this.Cherry.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cherry.Image = global::PacMan.Properties.Resources.cherry;
            this.Cherry.Location = new System.Drawing.Point(328, 464);
            this.Cherry.Name = "Cherry";
            this.Cherry.Size = new System.Drawing.Size(20, 20);
            this.Cherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cherry.TabIndex = 8;
            this.Cherry.TabStop = false;
            this.Cherry.Tag = "Cherry";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Broadway", 12F);
            this.LNombre.Location = new System.Drawing.Point(12, 9);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(64, 19);
            this.LNombre.TabIndex = 9;
            this.LNombre.Text = "label1";
            // 
            // LScore
            // 
            this.LScore.AutoSize = true;
            this.LScore.Font = new System.Drawing.Font("Broadway", 20F);
            this.LScore.Location = new System.Drawing.Point(314, 9);
            this.LScore.Name = "LScore";
            this.LScore.Size = new System.Drawing.Size(106, 31);
            this.LScore.TabIndex = 10;
            this.LScore.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LGO
            // 
            this.LGO.AutoSize = true;
            this.LGO.Font = new System.Drawing.Font("Broadway", 50F);
            this.LGO.Location = new System.Drawing.Point(165, 208);
            this.LGO.Name = "LGO";
            this.LGO.Size = new System.Drawing.Size(434, 76);
            this.LGO.TabIndex = 11;
            this.LGO.Text = "Game Over";
            this.LGO.Visible = false;
            // 
            // wall2
            // 
            this.wall2.Location = new System.Drawing.Point(746, 46);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(10, 438);
            this.wall2.TabIndex = 12;
            this.wall2.TabStop = false;
            this.wall2.Tag = "wall";
            // 
            // wall3
            // 
            this.wall3.Location = new System.Drawing.Point(0, 46);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(10, 438);
            this.wall3.TabIndex = 13;
            this.wall3.TabStop = false;
            this.wall3.Tag = "wall";
            // 
            // wall4
            // 
            this.wall4.Location = new System.Drawing.Point(0, 474);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(756, 10);
            this.wall4.TabIndex = 14;
            this.wall4.TabStop = false;
            this.wall4.Tag = "wall";
            // 
            // wall1
            // 
            this.wall1.Location = new System.Drawing.Point(0, 43);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(756, 10);
            this.wall1.TabIndex = 15;
            this.wall1.TabStop = false;
            this.wall1.Tag = "wall";
            // 
            // BReiniciar
            // 
            this.BReiniciar.Location = new System.Drawing.Point(336, 287);
            this.BReiniciar.Name = "BReiniciar";
            this.BReiniciar.Size = new System.Drawing.Size(75, 23);
            this.BReiniciar.TabIndex = 16;
            this.BReiniciar.Text = "Reiniciar";
            this.BReiniciar.UseVisualStyleBackColor = true;
            this.BReiniciar.Visible = false;
            this.BReiniciar.Click += new System.EventHandler(this.BReiniciar_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(336, 316);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(756, 484);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BReiniciar);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.LGO);
            this.Controls.Add(this.LScore);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.Cherry);
            this.Controls.Add(this.Tile);
            this.Controls.Add(this.Pacman);
            this.Controls.Add(this.FRosado);
            this.Controls.Add(this.FRojo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDowm);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.FRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRosado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox FRojo;
        private System.Windows.Forms.PictureBox FRosado;
        private System.Windows.Forms.PictureBox Pacman;
        private System.Windows.Forms.PictureBox Tile;
        private System.Windows.Forms.PictureBox Cherry;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LGO;
        private System.Windows.Forms.PictureBox wall2;
        private System.Windows.Forms.PictureBox wall3;
        private System.Windows.Forms.PictureBox wall4;
        private System.Windows.Forms.PictureBox wall1;
        private System.Windows.Forms.Button BReiniciar;
        private System.Windows.Forms.Button Exit;
    }
}

