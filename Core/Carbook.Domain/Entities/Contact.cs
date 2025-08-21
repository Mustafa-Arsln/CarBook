using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbook.Domain.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Subject { get; set; }
        public String Massege { get; set; }
        public DateTime SendDate { get; set; }
    }
}
