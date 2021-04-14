using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public class UserDTO
    {
        public string User_Naam { get; set; }
        public string Achternaam { get; set; }
        public int BSN { get; set; }

        public UserDTO( string usernaam, string achternaam, int bsn)
        {
            this.User_Naam = usernaam;
            this.Achternaam = achternaam;
            this.BSN = bsn;
        }
    }
}
