using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    interface IUserDAL
    {
        public List<UserDTO> GetUsers();
    }
}
