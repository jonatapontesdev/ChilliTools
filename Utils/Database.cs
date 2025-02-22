using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace JPRagTools.Utils
{
    public static class Database
    {
        private static readonly string connectionString = "server=15.235.30.120;database=jpdigi15_chillitools;user=jpdigi15_chilli;password=Any@1515;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static string ValidateUser(string email)
        {
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT ativo FROM usuarios WHERE email = @Email";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        return "Email não cadastrado!";
                    }

                    int ativo = Convert.ToInt32(result);

                    if (ativo == 0)
                    {
                        return "Seu usuário está inativo! Entre em contato com o suporte.";
                    }

                    return "OK"; // Usuário ativo e válido
                }
            }
        }
    }
}