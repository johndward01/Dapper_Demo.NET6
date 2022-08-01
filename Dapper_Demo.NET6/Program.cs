using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;


IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();


string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);







