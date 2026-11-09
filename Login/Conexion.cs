using MySql.Data.MySqlClient;

namespace LoginBCrypt
{
    public class Conexion
    {
        private string cn = "server=localhost;database=Parcial_3;uid=root;pwd=***;";

        public MySqlConnection Conectar()
        {
            return new MySqlConnection(cn);
        }
    }
}
