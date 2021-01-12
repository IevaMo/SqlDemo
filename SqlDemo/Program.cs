using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=.;Database=DemoDb;Trusted_Connection=True;"; // uzrasoma nuoroda i mano duomenu baze

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open(); // atidaromas connection

                using (SqlCommand command = new SqlCommand("SELECT * FROM Fruits", con)) //nurodoma kokiakomanda bus sukuriama
                using (SqlDataReader reader = command.ExecuteReader()) //SELECT nuskaitymas
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1} {2}",
                        reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));

                    }
                }

                //con.Open();
               /* string sql = "INSERT INTO Fruits VALUES(@param1, @param2, @param3)";
                  using (SqlCommand cmd = new SqlCommand(sql,con)) // kiekvienam parametrui yra sukuriama Sql komanda
                  {
                      cmd.Parameters.Add("@param1", SqlDbType.Int).Value = 1; // specifikuojame, koki tipa norime ideti
                      cmd.Parameters.Add("@param2", SqlDbType.VarChar,50).Value = "Slyva";
                      cmd.Parameters.Add("@param3", SqlDbType.Int, 50).Value = 1;
                      cmd.CommandType = System.Data.CommandType.Text;
                      cmd.ExecuteNonQuery();
                  }

               /* var itemId = 5;
                   //con.Open();
                   string sql = $"delete from Fruits where id = {itemId}"; // istrynimas pagal Id
                   using (SqlCommand cmd = new SqlCommand(sql, con))
                   {
                       cmd.ExecuteNonQuery();

                       con.Close();
                   }*/
            }

            Console.ReadLine();
        }

    }
}
