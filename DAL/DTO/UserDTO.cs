using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public int AgendaID { get; set; }
        public string User_Naam { get; set; }
        public string Achternaam { get; set; }
        public int BSN { get; set; }

        public UserDTO(int userid, int agendaid, string usernaam, string achternaam, int bsn)
        {
            UserID = userid;
            AgendaID = agendaid;
            User_Naam = usernaam;
            Achternaam = achternaam;
            BSN = bsn;
        }

        public UserDTO()
        {

        }
    }
}
