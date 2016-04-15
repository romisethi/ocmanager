using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCManager.Interface.DataInterface;
using OCManager.Entities.DBEntities;

namespace OCManager.Data.DataServices
{
    public class OccurenceDataService : EntityFrameworkService, IOccurenceDataService
    {
        OCManagerContext dbContext = null;
        //public OccurenceDataService()
        //{
        //    dbContext = new OCManagerContext();
        //}
        public List<Occurence> GetOccurencesList()
        {
            return dbConnection.Occurences.Where(a => a.ID == 145828).ToList();
        }
    }
}
