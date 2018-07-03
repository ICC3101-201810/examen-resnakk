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
    public partial class Bienvenida : Form
    {
       
        
        public Bienvenida()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BEmpezar_Click(object sender, EventArgs e)
        {
            string nombre = TI.Text;
            User newUser = new User(nombre, 0);
            List<User> users = Datos.DesUsers();
            try
            {
                Datos.AddUser(newUser, users);
                
                Form1 juego = new Form1(newUser.Get_Nombre(),newUser.Get_score());
                juego.Show();
                
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
