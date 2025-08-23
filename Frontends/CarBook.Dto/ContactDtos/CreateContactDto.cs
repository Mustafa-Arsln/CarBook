using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.ContactDtos
{
    public class CreateContactDto
    {
        
        public String Name { get; set; }
        public String Email { get; set; }
        public String Subject { get; set; }
        public String Massege { get; set; }
        public DateTime SendDate { get; set; }
    }
}
