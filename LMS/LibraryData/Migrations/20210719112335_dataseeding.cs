using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.IO;

namespace LibraryData.Migrations
{
    public partial class dataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sqlConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Library_Dev;Trusted_Connection=True;MultipleActiveResultSets=True";


            string path = Path.Combine(Environment.CurrentDirectory, @"Sql\Test1.sql");

            string script = File.ReadAllText(path);

            SqlConnection conn = new SqlConnection(sqlConnectionString);

            Server server = new Server(new ServerConnection(conn));

            server.ConnectionContext.ExecuteNonQuery(script);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
