using System;
using System.Collections.Generic;
using System.Text;

namespace HotelEntities
{
    abstract class AEntity
    {
        
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
    }
}
