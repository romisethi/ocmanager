using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace OCManager.Entities.DBEntities
{

    [Table(Name = "Occurences")]
    public class Occurence
    {
        [Column(Storage = "id", CanBeNull = false)]
        public Int32 ID { get; set; }

        [Column(Storage = "event_id", CanBeNull = false)]
        public int Event_ID { get; set; }


        [Column(Storage = "start", CanBeNull = false)]
        public DateTime Start { get; set; }


        [Column(Storage = "end", CanBeNull = false)]
        public DateTime End { get; set; }


        [Column(Storage = "notes", CanBeNull = false)]
        public string Notes { get; set; }


        [Column(Storage = "location_id", CanBeNull = false)]
        public int Location_ID { get; set; }

        [Column(Storage = "user_id", CanBeNull = true)]
        public int User_ID { get; set; }

        [Column(Storage = "last_change_id", CanBeNull = true)]
        public int Last_Change_ID { get; set; }

        [Column(Storage = "external_id", CanBeNull = true)]
        public Nullable<Int32> External_ID { get; set; }

        [Column(Storage = "reason_code", CanBeNull = false)]
        public int Reason_Code { get; set; }

        [Column(Storage = "timestamp", CanBeNull = false)]
        public DateTime TimeStamp { get; set; }

        [Column(Storage = "walkin", CanBeNull = false)]
        public Int16 WalkIn { get; set; }

        [Column(Storage = "group_appointment", CanBeNull = false)]
        public Int16 Group_Appointment { get; set; }
    }
}
