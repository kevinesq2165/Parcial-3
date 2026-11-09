
using LoginBCrypt;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        Conexion db = new Conexion();

        public Form1()
        {
            InitializeComponent();
            txtContrasena.PasswordChar = '*';
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string u = txtUsuario.Text.Trim();
            string c = txtContrasena.Text;

            if (u == "" || c == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            try
            {
                string hash = BCrypt.Net.BCrypt.HashPassword(c);

                using (MySqlConnection con = db.Conectar())
                {
                    con.Open();

                    string sql = "INSERT INTO usuarios (usuario, clave) VALUES (@u, @c)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@u", u);
                        cmd.Parameters.AddWithValue("@c", hash);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario creado");
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("ya existe");
                else
                    MessageBox.Show("Error al guardar");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string u = txtUsuario.Text.Trim();
            string c = txtContrasena.Text;
            bool o = false;

            if (u == "" || c == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            try
            {
                using (MySqlConnection con = db.Conectar())
                {
                    con.Open();

                    string sql = "SELECT clave FROM usuarios WHERE usuario = @u";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@u", u);

                        object dato = cmd.ExecuteScalar();

                        if (dato != null)
                        {
                            string hash = dato.ToString();
                            o = BCrypt.Net.BCrypt.Verify(c, hash);
                        }
                    }

                    sql = "INSERT INTO intentos (usuario, resultado, fecha) " +
                          "VALUES (@u, @r, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@u", u);
                        cmd.Parameters.AddWithValue("@r", o ? "logrado" : "no logrado");
                        cmd.ExecuteNonQuery();
                    }
                }

                if (o)
                    MessageBox.Show("Hola " + u);
                else
                    MessageBox.Show("Usuario o contraseña incorrectos");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al iniciar sesión");
            }
        }
    }
}

