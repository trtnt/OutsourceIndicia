using System;
using System.Collections.Generic;
using System.Text;

namespace BAL
{
   public class User
    {
        public int UserID { get; set; }
        public int AgendaID { get; set; }
        public string User_Naam { get; set; }
        public string Achternaam { get; set; }
        public int BSN { get; set; }

        public User(int userid, int agendaid, string usernaam, string achternaam, int bsn)
        {
            this.UserID = userid;
            this.AgendaID = agendaid;
            this.User_Naam = usernaam;
            this.Achternaam = achternaam;
            this.BSN = bsn;
        }
    }

}
