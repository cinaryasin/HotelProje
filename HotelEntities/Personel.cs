using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelEntities
{
    public class Personel : AEntity
    {

        [Required(ErrorMessage ="Maaş Girilmedi")]
        public int? Salary { get; set; }
        [Required(ErrorMessage = "Adres girilmedi")]
        public string Adress { get; set; }

    }
 
}
