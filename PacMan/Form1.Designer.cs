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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.FRojo = new System.Windows.Forms.PictureBox();
            this.FRosado = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Tile = new System.Windows.Forms.PictureBox();
            this.Cherry = new System.Windows.Forms.PictureBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRosado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(454, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 153);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(199, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 153);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(555, 302);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 153);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(128, 322);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 153);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "wall";
            // 
            // FRojo
            // 
            this.FRojo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FRojo.Image = global::PacMan.Properties.Resources.red_left1;
            this.FRojo.Location = new System.Drawing.Point(229, 76);
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
            this.FRosado.Location = new System.Drawing.Point(513, 417);
            this.FRosado.Name = "FRosado";
            this.FRosado.Size = new System.Drawing.Size(36, 38);
            this.FRosado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FRosado.TabIndex = 5;
            this.FRosado.TabStop = false;
            this.FRosado.Tag = "fan1";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox5.Image = global::PacMan.Properties.Resources.pacman_right;
            this.pictureBox5.Location = new System.Drawing.Point(358, 287);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "fan1";
            // 
            // Tile
            // 
            this.Tile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tile.Image = global::PacMan.Properties.Resources.tile114;
            this.Tile.Location = new System.Drawing.Point(295, 169);
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
            this.Cherry.Location = new System.Drawing.Point(378, 156);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 505);
            this.Controls.Add(this.LScore);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.Cherry);
            this.Controls.Add(this.Tile);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.FRosado);
            this.Controls.Add(this.FRojo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDowm);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRosado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox FRojo;
        private System.Windows.Forms.PictureBox FRosado;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Tile;
        private System.Windows.Forms.PictureBox Cherry;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LScore;
        private System.Windows.Forms.Timer timer1;
    }
}

