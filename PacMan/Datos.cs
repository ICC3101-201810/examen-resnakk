using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace PacMan
{
    class Datos
    {
        public static List<User> users = new List<User>() { new User("Mauro",0)};
        public static bool VerUser(User user, List<User> users)
        {
            foreach (User item in users)
            {
                if (item.Get_Nombre() == user.Get_Nombre())
                {
                    return false;
                }
            }
            return true;
        }
        public static User BuscarUser(User user, List<User> users)
        {
            foreach (User item in users)
            {
                if (user.Get_Nombre() == item.Get_Nombre())
                {
                    return item;
                }
            }
            return null;
        }
        public static void AddUser(User user, List<User> users)
        {
            if (VerUser(user,users) == true)
            {
                users.Add(user);
                MessageBox.Show("Ha ingresado exitosamente");
            }
            else
            {
                user = BuscarUser(user, users);
                MessageBox.Show("Ha ingresado exitosamente");
                ;            }
        }
        public static void SerializarUsers(List<User> users)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Users.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, users);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            } 
        }
        public static List<User> DesUsers()
        {
            List<User> users;

            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Users.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    users = (List<User>)bin.Deserialize(stream);
                }
                return users;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
