using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProject.Model
{
    public class LoginUser: BDContext
    {

        //Global User Access.
        protected string _Username { get => _Username; set => _Username = value; }
        protected string _Userid { get => _Userid; set => _Userid = value; }

        //Database Access
        public bool Islogin(string user, string clave)
        {
            try
            {
                FMenu c = new FMenu(user);

                Command.Connection = connectionBD;
                Command.CommandText = "UserCredentials";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@usx", user);
                Command.Parameters.AddWithValue("@clx", clave);
                connectionBD.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    if (Convert.ToString(Reader["Nombre_Usuario"]) == user && Convert.ToString(Reader["Clave"]) == clave)
                    {
                        MessageBox.Show("Bienvenido ", user, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        c.Show();
                        return true;
                    }
                }
                Command.Parameters.Clear();
                Reader.Close();
                connectionBD.Close();
                return false;

            }
            catch (MySqlException ex)
            {
                Command.Parameters.Clear();
                Reader.Close();
                connectionBD.Close();
                MessageBox.Show("Usuario o Clave Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        internal void close(Form form, object x)
        {
            throw new NotImplementedException();
        }



        //Check-Username-pass
        public void isCheck(Boolean success)
        {
            if (success != true)
            {
                MessageBox.Show("Usuario o Clave Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
