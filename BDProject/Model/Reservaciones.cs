using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProject.Model
{
    public class Reservaciones: BDContext
    {
        public void registerRes(string resid,string resdir, string redi, string rmp, string idclt)
        {

            try
            {
                Command.Connection = connectionBD;
                Command.CommandText = "registerReservacion";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@idr", resid);
                Command.Parameters.AddWithValue("@dir", resdir);
                Command.Parameters.AddWithValue("@dis", redi);
                Command.Parameters.AddWithValue("@mpago", rmp);
                Command.Parameters.AddWithValue("@idclt", idclt);
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

        public void getListReservaciones(DataGridView tb_client)
        {
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataSet clientds = new DataSet();
                DataTable clientsTable = new DataTable();
                Command.Connection = connectionBD;
                Command.CommandText = "getReservaciones";
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
                        row.Cells[0].Value = rowClient["ID_Reservacion"].ToString();
                        row.Cells[1].Value = rowClient["Direccion"].ToString();
                        row.Cells[2].Value = rowClient["Dias"].ToString();
                        row.Cells[3].Value = rowClient["M_Pago"].ToString();
                        row.Cells[4].Value = rowClient["Id_Cliente"].ToString();
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
