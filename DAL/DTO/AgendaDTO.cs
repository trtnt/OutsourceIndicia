using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class AgendaDTO
    {
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public TimeSpan BeginTijd { get; set; }
        public TimeSpan EindTijd { get; set; }
        public string Omschrijving { get; set; }
        public string Categorie { get; set; }
        public string Locatie { get; set; }
        public string Agendatype { get; set; }

        public AgendaDTO()
        {

        }
        public AgendaDTO(DateTime begindatum, DateTime einddatum, TimeSpan begintijd, TimeSpan eindtijd, string omschrijving, string categorie, string locatie, string agendatype)
        {
            this.BeginDatum = begindatum;
            this.EindDatum = einddatum;
            this.BeginTijd = begintijd;
            this.EindTijd = eindtijd;
            this.Omschrijving = omschrijving;
            this.Categorie = categorie;
            this.Locatie = locatie;
            this.Agendatype = agendatype;
        }
    }

   
}
