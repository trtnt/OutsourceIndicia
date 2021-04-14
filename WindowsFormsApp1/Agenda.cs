using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public class Agenda
    {
        public int AgendaID { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public DateTime BeginTijd { get; set; }
        public DateTime EindTijd { get; set; }
        public int DeelnemerID { get; set; }
        public string Omschrijving { get; set; }
        public string Categorie { get; set; }
        public string Locatie { get; set; }
    }
}
