using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL
{
    class UserContainer
    {
        public List<User> getAll()
        {
            UserDAL userdal = new UserDAL();
            List<UserDTO> users = userdal.GetUsers();
            List<User> userlist = new List<User>();

            foreach (UserDTO user in users)
            {
                userlist.Add(new User(user.UserID, user.AgendaID, user.User_Naam, user.Achternaam, user.BSN));
            }

            return userlist;
        }
    }
}
