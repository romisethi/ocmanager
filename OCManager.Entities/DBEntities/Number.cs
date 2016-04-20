using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OCManager.Entities.DBEntities
{
    public class Number
    {
        [Key]
        [Column(Storage = "number_id", CanBeNull = false)]
        public Int32 Number_Id { get; set; }

        [Column(Storage = "number_type", CanBeNull = false)]
        public int Number_Type { get; set; }

        [Column(Storage = "notes", CanBeNull = false)]
        public string Notes { get; set; }

        [Column(Storage = "number", CanBeNull = false)]
        public string Num { get; set; }


        [Column(Storage = "active", CanBeNull = false)]
        public Int16 Active { get; set; }
    }
}
