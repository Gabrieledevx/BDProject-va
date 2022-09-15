using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProject.Model
{
    public class BDContext
    {
        //This data will remove at 01/OCT/2022 
        protected MySqlConnection connectionBD = new MySqlConnection("server=34.70.147.191" + "; port=3306" + "; user id=root" + "; password=tln36pkyg22" +
           "; database=pdbdd;");
        //Reader
        protected MySqlDataReader Reader;
        //Comandos
        protected MySqlCommand Command = new MySqlCommand();
    }
}
