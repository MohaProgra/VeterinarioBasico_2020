using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VeterinarioBasico_2020
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 192.168.71.159; Database = veterinario; Uid = root; Pwd =; Port = 3306");
        }
        public String loginVeterinario(String DNI, String Contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    
                new MySqlCommand("SELECT * FROM usuario where DNI = @DNI AND Contraseña = @Contraseña", conexion);

                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Contraseña", Contraseña);


                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    return resultado.GetString(0);
                }

                conexion.Close();
                return "error de usuario/contraseña";
            }
            catch (MySqlException e)
            {
                return "error";
            }

        }

    

    }
}



