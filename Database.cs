using System;
using System.IO.Pipelines;
using MySql.Data.MySqlClient;

namespace LINQ_adatbazis_feladat;

internal class Database
{
    private string connectionString = "server=127.0.0.1;port=4200;database=db;uid=root;pwd=root;";
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
                    while(reader.Read())
                    {
                        Diak diak = new(
                            Convert.ToInt32(reader[0]),
                            reader[1].ToString(),
                            Convert.ToInt32(reader[2]),
                            reader[3].ToString(),
                            Convert.ToDouble(reader[4])
                        );
                        diakok.Add(diak);
                    }
                }
            }
        }
        return diakok;
    }
}
