using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarioComGoogle2.Models
{
    public class EventViewModel
    {
        public String id { get; set; }

        public String title { get; set; }

        public String start { get; set; }

        public String end { get; set; }

        public bool allDay { get; set; }
    }
}
