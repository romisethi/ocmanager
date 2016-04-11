using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OCManager.Models
{
    public class EventTask
    {
        public int TaskID { get; set; }
        public string Text { get; set; }
        public DateTime? DueDate { get; set; }
        public string Priority { get; set; }
    }
}