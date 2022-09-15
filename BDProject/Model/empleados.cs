using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProject.Model
{
    public class empleados: BDContext
    {
        public void linkemp(string empid, string usid)
        {

            try
            {
                Command.Connection = connectionBD;
                Command.CommandText = "registerEmpleado";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@ide", empid);
                Command.Parameters.AddWithValue("@idp", usid);
                connectionBD.Open();
                Reader = Command.ExecuteReader();
                MessageBox.Show("Exito", "Se ha creado la relación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void getListEmpleados(DataGridView tb_client)
        {
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataSet clientds = new DataSet();
                DataTable clientsTable = new DataTable();
                Command.Connection = connectionBD;
                Command.CommandText = "getEmpleados";
                Command.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand = Command;
                dataAdapter.Fill(clientds);
                connectionBD.Open();
                Reader = Command.ExecuteReader();
                clientsTable = clientds.Tables[0];
                tb_client.Rows.Clear();
                try
                {
                    for (int i = 0; i < clientsTable.Rows.Count; i++)
                    {
                        DataRow rowClient = clientsTable.Rows[i];
                        DataGridViewRow row = (DataGridViewRow)tb_client.Rows[i].Clone();
                        row.Cells[0].Value = rowClient["IdEmpleados"].ToString();
                        row.Cells[1].Value = rowClient["Id_persona"].ToString();
                        row.Cells[2].Value = rowClient["Nombres"].ToString();
                        row.Cells[3].Value = rowClient["Apellidos"].ToString();
                        row.Cells[4].Value = rowClient["Edad"].ToString();
                        row.Cells[5].Value = rowClient["Correo"].ToString();
                        row.Cells[6].Value = rowClient["Celular"].ToString();
                        tb_client.Rows.Add(row);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                Command.Parameters.Clear();
                Reader.Close();
                connectionBD.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(" " + ex);
            }
        }

    }
}
