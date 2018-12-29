using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLinks
{
    public class SqlLink
    {
        private SqlConnection Connection;
        private SqlDataAdapter Adapter;
        private DataSet SetData;

        //private String ServerName = "DESKTOP-6GI6MES\\SQLEXPRESS";
        private String ServerName = "DESKTOP-87OOTCP";
        private String DbName = "QLCAFE";

        public SqlLink()
        {
            try
            {
                String connectionString = "Data source=" + ServerName + "; database=" + DbName + "; Integrated Security=SSPI";
                Connection = new SqlConnection(connectionString);
            }
            catch (SqlException)
            {
                System.Environment.Exit(0);
            }
        }

        public DataTable Select(String cmd)
        {
            Adapter = new SqlDataAdapter(cmd, Connection);
            SetData = new DataSet();
            Adapter.Fill(SetData);
            return SetData.Tables[0];
        }

        public void NonSelect(String Command)
        {
            SqlCommand SqlCommand = new SqlCommand(Command, Connection);
            Connection.Open();
            SqlCommand.ExecuteNonQuery();
            Connection.Close();
        }

    }
}
