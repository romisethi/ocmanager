using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCManager.Entities.DBEntities
{
    [System.Data.Linq.Mapping.Table(Name = "person_number")]
    public class PersonNumber
    {
        [Key]
        [Column(Order = 0)]
        [System.Data.Linq.Mapping.Column(Storage = "person_id", CanBeNull = false)]
        public int Person_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [System.Data.Linq.Mapping.Column(Storage = "number_id", CanBeNull = false)]
        public int Number_Id { get; set; }
    }
}
