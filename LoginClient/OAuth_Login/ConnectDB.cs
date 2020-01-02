using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth_Login
{
    class ConnectDB
    {
        // DB 접속 경로
        public static string src = @"Data Source=127.0.0.1; Initial Catalog=MemberDB;";
        SqlConnection connect = new SqlConnection();
        private string sConnect = "";
        SqlCommand cmd = new SqlCommand("Select name, nickname, email, birthday, age, gender from Table");
        SqlDataReader reader;

        // DB 접속하기
        public void ConnectToDB()
        {
            try
            {
                sConnect = src;
            }
            catch (Exception)
            {
                throw;
            }

            if (connect.State.ToString().Equals("Closed"))
            {
                connect.ConnectionString = sConnect;
                cmd.Connection = connect;
                connect.Open();
            }
        }

        // DB 정보 가져오기
        public string GetName()
        {
            reader = cmd.ExecuteReader();
            reader.Read();
            return reader["name"].ToString();
        }
        public string GetNick()
        {
            reader = cmd.ExecuteReader();
            reader.Read();
            return reader["nickname"].ToString();
        }
        public string GetEmail()
        {
            reader = cmd.ExecuteReader();
            reader.Read();
            return reader["email"].ToString();
        }
        public string GetBirth()
        {
            reader = cmd.ExecuteReader();
            reader.Read();
            return reader["birthday"].ToString();
        }
        public string GetAge()
        {
            reader = cmd.ExecuteReader();
            reader.Read();
            return reader["age"].ToString();
        }
        public string GetGender()
        {
            reader = cmd.ExecuteReader();
            reader.Read();
            return reader["gender"].ToString();
        }


        // DB 접속 끊기
        public void CloseDB()
        {
            if (connect != null)
            {
                connect.Close();
            }
        }

        public DataTable GetDBTable(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
