using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCManager.Entities.DBEntities
{
    [Table(Name="person_number")]
    public class PersonNumber
    {
        [Column(Storage = "person_id", CanBeNull = false)]
        public int Person_ID { get; set; }

        [Column(Storage = "number_id", CanBeNull = false)]
        public int Number_Id { get; set; }
    }
}
