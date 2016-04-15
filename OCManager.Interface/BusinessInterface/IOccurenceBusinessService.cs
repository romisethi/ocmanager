using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCManager.Entities.DBEntities;

namespace OCManager.Interface.BusinessInterface
{
    public interface IOccurenceBusinessService
    {
        List<Occurence> GetOccurencesList();
    }
}
