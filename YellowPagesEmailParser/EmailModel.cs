using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YellowPagesEmailParser
{
    public class EmailModel
    {
        public Int32 IDNumber { get; set; }
        public String AccountInstanceID { get; set; }
        public Int32 OrderHeaderIDNumber { get; set; }
        public String Caption { get; set; }
        public String DetailText { get; set; }
        public Int32 ProductIDNumber { get; set; }
    }
}
