using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournaments.Models;

namespace Tournaments.DAL
{
    public interface IEventRepository : IRepositoryBase<Event>
    {
        //Event GetById(int id);
    }
}
