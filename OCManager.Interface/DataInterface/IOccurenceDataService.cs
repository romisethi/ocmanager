using OCManager.Entities.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCManager.Interface.DataInterface
{
    public interface IOccurenceDataService:IDataRepository
    {
        List<Occurence> GetOccurencesList();
    }
}
