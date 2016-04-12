using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OCManager.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("tblEvent")]
    public class EventTask
    {
        [Key]
        public int TaskID { get; set; }
        public string Text { get; set; }
        public DateTime? DueDate { get; set; }
        public string Priority { get; set; }
    }
}