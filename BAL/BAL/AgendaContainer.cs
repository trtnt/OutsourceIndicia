using System;
using System.Collections.Generic;
using System.Text;
using BAL;
using DAL;

namespace BAL
{
    public class AgendaContainer
    {
        public AgendaContainer(AgendaDAL agendaDAL)
        {
        }

        public AgendaContainer()
        {
        }

        public void insert(Agenda agenda)
        {
            AgendaDAL agendaDAL = new AgendaDAL();
            agendaDAL.Insert(new AgendaDTO(agenda.BeginDatum, agenda.EindDatum, agenda.BeginTijd, agenda.EindTijd, agenda.Omschrijving, agenda.Categorie, agenda.Locatie, agenda.Agendatype));
        }

        public List<Agenda> getAll(DateTime begindatum)
        {
            AgendaDAL agendadal = new AgendaDAL();
            List<AgendaDTO> agendas = agendadal.GetAgenda(begindatum);
            List<Agenda> agendalist = new List<Agenda>();

            foreach (AgendaDTO agenda in agendas)
            {
                agendalist.Add(new Agenda(agenda.BeginDatum, agenda.EindDatum, agenda.BeginTijd, agenda.EindTijd, agenda.Omschrijving, agenda.Categorie, agenda.Locatie, agenda.Agendatype));
            }

            return agendalist;
        }
    }
}
