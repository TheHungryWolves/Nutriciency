using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        String username = txtUsername.Text;
        String password = txtPassword.Text;
        String sqlQuery = "BEGIN\n" +
            "SET NOCOUNT ON\n" +
            "DECLARE @username varchar(30),\n" +
            "@password varchar(30)\n" +
            "SET @username = '" + username + "'\n" +
            "SET @password = '" + password + "'\n" +
            "SELECT count(*) as Count FROM Users WHERE username = @username AND password = @password" +
            "\nEND";
        //String connectionString = @"Server=nutriciency.cob6xetmjpl4.us-east-1.rds.amazonaws.com,1433;Database=Nutriciency;User ID=Nutriciency;Password=COBcis2018*;Trusted_Connection=Yes;";
        //ConnectionStringSettings mySetting = ConfigurationManager.ConnectionStrings["logIn"];
        //String connectionString = mySetting.ConnectionString;

        SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
        connectionString.UserID = "Nutriciency";
        connectionString.Password = "COBcis2018*";
        connectionString.DataSource = "nutriciency.cob6xetmjpl4.us-east-1.rds.amazonaws.com,1433";
        connectionString.InitialCatalog = "Nutriciency";
        connectionString.IntegratedSecurity = false;

        int auth = 0;
        using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    auth = reader.GetInt32(reader.GetOrdinal("Count"));
                }
            }
            catch (Exception h)
            {
                lblExample.Text = h.ToString();
            }
        }

        if (auth == 1)
        {
            lblExample.Text = "Nice";
            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
            {
                try
                {
                    sqlQuery = "INSERT INTO dbo.Halloween VALUES ('Peter', 'scarecrow', 'bruce');";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        auth = reader.GetInt32(reader.GetOrdinal("Count"));
                    }
                }
                catch (Exception h)
                {
                    lblExample.Text = h.ToString();
                }
            }
        }
        else
        {
            lblExample.Text = "Sorry, user not found.";
        }

    }
}
