using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class UserDAL
    {

        private SqlConnection con;

        public void Connection()
        {
            string constring = @"Server=mssql.fhict.local;Database=dbi432186;User Id=dbi432186;Password=axioutsource1;";
            con = new SqlConnection(constring);
        }

        public List<User> GetUsers()
        {
            Connection();
            List<User> userlist = new List<User>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.User", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                userlist.Add(
                    new User
                    {
                        UserID = Convert.ToInt32(dr["User_Id"]),
                        User_Naam = Convert.ToString(dr["User_Naam"]),
                        Achternaam = Convert.ToString(dr["Achternaam"]),
                        BSN = Convert.ToInt32(dr["BSN"]),
                        AgendaID = Convert.ToInt32(dr["Agenda_Id"])

                    });
            }
            return userlist;
        }
    }
}
