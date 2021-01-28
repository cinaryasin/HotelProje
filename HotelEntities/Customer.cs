using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HotelEntities
{
    public class Customer : AEntity
    {
        [Required]
        public string TcNo { get; set; }


        [Required]
        [MinLength(5,ErrorMessage ="5 karakterden düşük giremezsiniz")]
        public string EMail { get; set; }


    }

}
