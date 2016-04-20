using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCManager.Entities.DBEntities
{
    [Table(Name="user")]
    public class User
    {
        [Key]
        [Column(Storage = "user_id", CanBeNull = false)]
        public Int32 User_ID { get; set; }

        [Column(Storage = "username", CanBeNull = false)]
        public string username { get; set; }

        [Column(Storage = "password", CanBeNull = false)]
        public string Password { get; set; }

        [Column(Storage = "nickname", CanBeNull = false)]
        public string Nickname { get; set; }


        [Column(Storage = "color", CanBeNull = false)]
        public string Color { get; set; }


        [Column(Storage = "person_id", CanBeNull = false)]
        public int Person_Id { get; set; }

        [Column(Storage = "disabled", CanBeNull = true)]
        public string Disabled { get; set; }

        [Column(Storage = "default_location_id", CanBeNull = true)]
        public int Default_Location_ID { get; set; }
    }
}
