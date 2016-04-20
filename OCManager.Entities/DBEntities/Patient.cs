using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCManager.Entities.DBEntities
{
    [Table(Name="Patient")]
    public class Patient
    {
        [Key]
        [Column(Storage = "person_id", CanBeNull = false)]
        public Int32 Person_ID { get; set; }

        [Column(Storage = "is_default_provider_primary", CanBeNull = false)]
        public int Is_Default_Provider_Primary { get; set; }

        [Column(Storage = "default_provider", CanBeNull = false)]
        public string Default_Provider { get; set; }


        [Column(Storage = "record_number", CanBeNull = false)]
        public int Record_Number { get; set; }


        [Column(Storage = "employer_name", CanBeNull = false)]
        public string Employer_Name { get; set; }


        [Column(Storage = "payer_id", CanBeNull = false)]
        public int Payer_Id { get; set; }

        [Column(Storage = "default_manager", CanBeNull = true)]
        public string Default_Manager { get; set; }

        [Column(Storage = "ts", CanBeNull = true)]
        public DateTime Ts { get; set; }

        [Column(Storage = "old_numbs", CanBeNull = true)]
        public int Old_Numbs { get; set; }

        [Column(Storage = "sequence", CanBeNull = false)]
        public int Sequence { get; set; }

        [Column(Storage = "discount2015", CanBeNull = false)]
        public int Discount2015 { get; set; }
    }
}
