﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WindowsFormsApp1
{
    class AgendaDAL
    {
        private SqlConnection con;

        public void Connection()
        {
            string constring = @"Server=mssql.fhict.local;Database=dbi432186;User Id=dbi432186;Password=axioutsource1;";
            con = new SqlConnection(constring);
        }

        public List<Agenda> GetAgenda()
        {
            Connection();
            List<Agenda> agendalist = new List<Agenda>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Agenda", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                agendalist.Add(
                    new Agenda
                    {
                        AgendaID = Convert.ToInt32(dr["Agenda_Id"]),
                        BeginDatum = Convert.ToDateTime(dr["BeginDatum"]),
                        EindDatum = Convert.ToDateTime(dr["EindDatum"]),
                        BeginTijd = Convert.ToDateTime(dr["BeginTijd"]),
                        EindTijd = Convert.ToDateTime(dr["EindTijd"]),
                        DeelnemerID = Convert.ToInt32(dr["Deelnemer_Id"]),
                        Omschrijving = Convert.ToString(dr["Omschrijving"]),
                        Categorie = Convert.ToString(dr["Categorie"]),
                        Locatie = Convert.ToString(dr["Categorie"])
                    });
            }
            return agendalist;
        }

        public int Insert(AgendaDTO agendaDTO)
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
                return dCmd.ExecuteNonQuery();
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
