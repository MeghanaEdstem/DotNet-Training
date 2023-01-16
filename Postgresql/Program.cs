using Npgsql;

var cs = "Host=localhost;Username=postgres;Password=postgres;Database=testdb";

using var con = new NpgsqlConnection(cs);
con.Open();

using var cmd = new NpgsqlCommand();
cmd.Connection = con;

cmd.CommandText = "DROP TABLE IF EXISTS cars";
cmd.ExecuteNonQuery();

cmd.CommandText = @"CREATE TABLE cars(id SERIAL PRIMARY KEY,
        name VARCHAR(255), price INT)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mercedes',57127)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Skoda',9000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volvo',29000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Bentley',350000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Citroen',21000)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Hummer',41400)";
cmd.ExecuteNonQuery();

cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volkswagen',21600)";
cmd.ExecuteNonQuery();

Console.WriteLine("Table cars created");

//add a new car to the cars table

var sql = "INSERT INTO cars(name, price) VALUES(@name, @price)";
using var cmd1 = new NpgsqlCommand(sql, con);

cmd1.Parameters.AddWithValue("name", "BMW");
cmd1.Parameters.AddWithValue("price", 36600);
cmd1.Prepare();

cmd1.ExecuteNonQuery();

Console.WriteLine("row inserted");

//retrieve data from the database
/*
string sql1 = "select * from cars";
using var cmd2 = new NpgsqlCommand(sql1, con);

using NpgsqlDataReader rdr = cmd2.ExecuteReader();  // npgsqldatareader is an object used to retrieve data from the database

while (rdr.Read())
{
    Console.WriteLine("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1),
            rdr.GetInt32(2));
}
*/

var sql2 = "SELECT * FROM cars";

using var cmd3 = new NpgsqlCommand(sql2, con);

using NpgsqlDataReader rdr1 = cmd3.ExecuteReader();
Console.WriteLine($"{rdr1.GetName(0),-4} {rdr1.GetName(1),-10} {rdr1.GetName(2),10}");

while (rdr1.Read())
{
    Console.WriteLine($"{rdr1.GetInt32(0),-4} {rdr1.GetString(1),-10} {rdr1.GetInt32(2),10}");
}
