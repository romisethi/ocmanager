using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCManager.Entities.DBEntities
{
    [Table(Name="Person")]
    public class Person
    {
        [Column(Storage = "person_id", CanBeNull = false)]
        public Int32 Person_ID { get; set; }

        [Column(Storage = "salutation", CanBeNull = false)]
        public int Salutation { get; set; }

        [Column(Storage = "last_name", CanBeNull = false)]
        public string Last_Name { get; set; }


        [Column(Storage = "first_name", CanBeNull = false)]
        public string First_Name { get; set; }


        [Column(Storage = "middle_name", CanBeNull = false)]
        public string Middle_Name { get; set; }


        [Column(Storage = "gender", CanBeNull = false)]
        public int Gender { get; set; }

        [Column(Storage = "initials", CanBeNull = true)]
        public string Initials { get; set; }

        [Column(Storage = "date_of_birth", CanBeNull = true)]
        public DateTime Date_Of_Birth { get; set; }

        [Column(Storage = "summary", CanBeNull = true)]
        public string Summary { get; set; }

        [Column(Storage = "title", CanBeNull = false)]
        public string Title { get; set; }

        [Column(Storage = "notes", CanBeNull = false)]
        public string Notes { get; set; }

        [Column(Storage = "email", CanBeNull = false)]
        public string  Email { get; set; }

        [Column(Storage = "secondary_email", CanBeNull = false)]
        public string Secondary_Email { get; set; }

        [Column(Storage = "has_photo", CanBeNull = false)]
        public string Has_Photo { get; set; }

        [Column(Storage = "identifier", CanBeNull = false)]
        public string Identifier { get; set; }

        [Column(Storage = "identifier_type", CanBeNull = false)]
        public string Identifier_Type { get; set; }

        [Column(Storage = "marital_status", CanBeNull = false)]
        public string Marital_Status { get; set; }
        [Column(Storage = "ts", CanBeNull = false)]
        public DateTime Marital_Status { get; set; }
    }
}
