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
            //dbConnection.Occurences
            //   .GroupJoin(dbConnection.Person,
            //              oc => oc.External_ID,
            //              p => p.Person_ID,
            //              (oc, p) => new { occurence = oc, person = p.FirstOrDefault() })
            //   .GroupJoin(dbConnection.Patient,
            //              oc_p => oc_p.person.Person_ID,
            //              pat => pat.Person_ID,
            //              (oc_p, pat) => new { occurencePer = oc_p, patient = pat })
            //   .GroupJoin(dbConnection.PersonNumber,
            //              oc_p_pat => oc_p_pat.occurencePer.person.Person_ID,
            //              pn =>pn.Person_ID,
            //              (oc_p_pat,pn) => new { occurencePer_pat = oc_p_pat, personNumber = pn.FirstOrDefault() })
            //    .GroupJoin(dbConnection.Number,
            //               oc_p_pat_pn => oc_p_pat_pn.personNumber.Number_Id,
            //               n => n.Number_Id,
            //               (oc_p_pat_pn, n) => new {occurencePer_pat_pn = oc_p_pat_pn, number = n})
            //    .GroupJoin(dbConnection.User,
            //                oc_p_pat_pn_n => oc_p_pat_pn_n.occurencePer_pat_pn.occurencePer_pat.occurencePer.occurence.Last_Change_ID,
            //                u=> u.User_ID,
            //                (oc_p_pat_pn_n, u) => new { occurencePar})
                            
            return dbConnection.Occurences.Where(a => a.ID == 145828).ToList();
        }
    }
}
