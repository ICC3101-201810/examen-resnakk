using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PacMan
{
    public partial class Form1 : Form
    {
        //Pac
        bool up;
        bool down;
        bool left;
        bool right;
        int speedp = 5;
        
        //Ghost
        int speedF1 = 8;
        int speedF2 = 8;

        int score = 0;
        
        public Form1()
        {
            InitializeComponent();
            Pacman.Left = 358;
            Pacman.Top = 229;
            Random ran = new Random();

            FRojo.Left = ran.Next(11, 700);
            FRojo.Top = ran.Next(11, 380);
            FRosado.Left = ran.Next(11, 700);
            FRosado.Top = ran.Next(11, 380);
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
                
            }
            else if (e.KeyCode == Keys.Right)
            {
                right = false;
                
            }
            else if (e.KeyCode == Keys.Up)
            {
                up = false;
                
            }
            else if (e.KeyCode == Keys.Down)
            {
                down = false;
                
            }
        }

        private void KeyisDowm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = true;
                Pacman.Image = Properties.Resources.pacman_left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                right = true;
                Pacman.Image = Properties.Resources.pacman_right;
            }
            else if (e.KeyCode == Keys.Up)
            {
                up = true;
                Pacman.Image = Properties.Resources.pacman_up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                down = true;
                Pacman.Image = Properties.Resources.pacman_down;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LScore.Text = "Score: " + score.ToString();
            if (left)
            {
                Pacman.Left -= speedp;
            }
            else if (right)
            {
                Pacman.Left += speedp;
            }
            else if (down)
            {
                Pacman.Top += speedp;
            }
            else if (up)
            {
                Pacman.Top -= speedp;
            }

            FRojo.Left += speedF1;
            FRosado.Left += speedF2;
            if (FRojo.Bounds.IntersectsWith(wall1.Bounds)|| FRojo.Bounds.IntersectsWith(wall2.Bounds)|| FRojo.Bounds.IntersectsWith(wall3.Bounds)|| FRojo.Bounds.IntersectsWith(wall4.Bounds))
            {
                speedF1 = -speedF1;
            }
            else if (FRosado.Bounds.IntersectsWith(wall1.Bounds)|| FRosado.Bounds.IntersectsWith(wall2.Bounds)|| FRosado.Bounds.IntersectsWith(wall3.Bounds)||FRosado.Bounds.IntersectsWith(wall4.Bounds))
            {
                speedF2 = -speedF2;
            }

            if (Pacman.Bounds.IntersectsWith(FRojo.Bounds) || Pacman.Bounds.IntersectsWith(FRosado.Bounds))
            {
                Pacman.Left = 0;
                Pacman.Top = 25;
                LGO.Visible = true;
                BReiniciar.Visible = true;
                Exit.Visible = true;
                timer1.Stop();
                
            }

        }

        private void BReiniciar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
