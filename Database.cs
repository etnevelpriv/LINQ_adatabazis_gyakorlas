using System;
using MySql.Data.MySqlClient;

namespace LINQ_adatbazis_feladat;

internal class Database
{
    private string connectionString = "server=127.0.0.1;database=db;uid=root;pwd=root;";
    public List<Diak> DiakokBetoltese()
    {
        List<Diak> diakok = new();
        using (MySqlConnection connection = new(connectionString))
        {
            string query = "SELECT * FROM diakok";
            using (MySqlCommand command = new(query, connection))
            {
                connection.Open();
                using(MySqlDataReader reader = command.ExecuteReader())
                {
                    
                }
            }
        }
        return diakok;
    }
}
