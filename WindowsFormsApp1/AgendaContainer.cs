using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public class AgendaContainer
    {
        public int insert(Agenda agenda)
        {
            AgendaDAL agendaDAL = new AgendaDAL();
            return agendaDAL.Insert(new AgendaDTO(agenda.BeginDatum, agenda.EindDatum, agenda.BeginTijd, agenda.EindTijd, agenda.Omschrijving, agenda.Categorie, agenda.Locatie));
        }
    }
}
