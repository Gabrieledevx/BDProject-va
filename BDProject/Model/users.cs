using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProject.Model
{
    public class users:BDContext
    {
        //Create Users

        public void registerUser(string id, string nombre, string clave)
        {
            
            try
            {
                Command.Connection = connectionBD;
                Command.CommandText = "createUser";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@idu", id);
                Command.Parameters.AddWithValue("@nomsu", nombre);
                Command.Parameters.AddWithValue("@cv", clave);
                connectionBD.Open();
                Reader = Command.ExecuteReader();
                MessageBox.Show("Exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Command.Parameters.Clear();
                Reader.Close();
                connectionBD.Close();

            }
            catch (MySqlException ex)
            {
                connectionBD.Close();
                MessageBox.Show("Error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
