using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    interface IAgendaDAL
    {
        public List<AgendaDTO> GetAgenda(DateTime begindatum);
        public void Insert(AgendaDTO agendaDTO);
    }
}
