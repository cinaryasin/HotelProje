using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelEntities
{
    public class Personel : AEntity
    {

        [Required]
        public int Salary { get; set; }
        [Required]
        public string Adress { get; set; }

    }
 
}
