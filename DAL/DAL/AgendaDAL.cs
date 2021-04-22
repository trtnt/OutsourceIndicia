using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class AgendaDAL
    {
        private SqlConnection con;

        public void Connection()
        {
            string constring = @"Server=mssql.fhict.local;Database=dbi432186;User Id=dbi432186;Password=axioutsource1;";
            con = new SqlConnection(constring);
        }

        public List<AgendaDTO> GetAgenda(DateTime begindatum)
        {
            Connection();
        
            List<AgendaDTO> agendalist = new List<AgendaDTO>();

            SqlCommand cmd = new SqlCommand("dbo.GetDetails" , con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@begindatum", begindatum);

            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                agendalist.Add(
                    new AgendaDTO
                    {
                        BeginDatum = Convert.ToDateTime(dr["BeginDatum"]),
                        EindDatum = Convert.ToDateTime(dr["EindDatum"]),
                        BeginTijd =  TimeSpan.Parse(dr["BeginTijd"].ToString()),
                        EindTijd = TimeSpan.Parse(dr["EindTijd"].ToString()),
                        Omschrijving = Convert.ToString(dr["Omschrijving"]),
                        Categorie = Convert.ToString(dr["Categorie"]),
                        Locatie = Convert.ToString(dr["Locatie"])
                    });
            }
            return agendalist;
        }

        public void Insert(AgendaDTO agendaDTO)
        {
            Connection();
            con.Open();
            string cmd = "INSERT into dbo.Agenda (BeginDatum,EindDatum,BeginTijd,EindTijd,Omschrijving,Categorie,Locatie) VALUES (@begindatum, @einddatum, @begintijd, @eindtijd, @omschrijving, @categorie, @locatie )";

            SqlCommand dCmd = new SqlCommand(cmd, con);
            try
            {
                dCmd.Parameters.AddWithValue("@begindatum", agendaDTO.BeginDatum);
                dCmd.Parameters.AddWithValue("@einddatum", agendaDTO.EindDatum);
                dCmd.Parameters.AddWithValue("@begintijd", agendaDTO.BeginTijd);
                dCmd.Parameters.AddWithValue("@eindtijd", agendaDTO.EindTijd);
                dCmd.Parameters.AddWithValue("@omschrijving", agendaDTO.Omschrijving);
                dCmd.Parameters.AddWithValue("@categorie", agendaDTO.Categorie);
                dCmd.Parameters.AddWithValue("@locatie", agendaDTO.Locatie);
                dCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }
    }
}
