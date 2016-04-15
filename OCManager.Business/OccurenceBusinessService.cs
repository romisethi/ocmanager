using OCManager.Interface.BusinessInterface;
using OCManager.Interface.DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCManager.Business
{
    public class OccurenceBusinessService : IOccurenceBusinessService
    {
        IOccurenceDataService _occurenceDataService;
        public OccurenceBusinessService(IOccurenceDataService occurenceDataService)
        {
            _occurenceDataService = occurenceDataService;
        }
        public List<OCManager.Entities.DBEntities.Occurence> GetOccurencesList()
        {
            try
            {
                _occurenceDataService.CreateSession();
                return _occurenceDataService.GetOccurencesList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
