using System;
using System.ComponentModel.DataAnnotations;

namespace HotelEntities
{
    public class Customer:AEntity
    {
        [Required]
        public string TcNo { get; set; }
        [Required]
        public string EMail { get; set; }
    }
}
