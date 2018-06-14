using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Repositories
{
    public class EventRepository : BaseRepository<Event>
    {

        public EventRepository(EventManagerEntities context)
            : base(context)
        {
        }

        public override void Save(Event item)
        {
            if(item.ID == 0)
            {
                base.Create(item);
            }
            else
            {
                base.Update(item, e => e.ID == item.ID);
            }
        }
    }
}
