using System;
using HotelBusiness.ConCrete;
namespace HotelMain
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var customerManager = new HotelBusiness.ConCrete.CustomerManager();
            var personelManager = new HotelBusiness.ConCrete.PersonelManager();
            bool result = customerManager.Insert(new HotelEntities.Customer { Id = 1, FirsName = "Yasin", LastName = "Çınar", EMail = "aaa", TcNo = "12132132" });
            bool result2 = personelManager.Insert(new HotelEntities.Personel { Id = 2, FirsName = "Ahmet", LastName = "Sefa", Salary=null, Adress = "" }) ; 

            


            if (result)
            {
                Console.WriteLine("müşteri Eklendi");
            }
            else
            {
                Console.WriteLine("müşteri Eklenmedi!!");
            }

            if (result2)
            {
                Console.WriteLine("personel Eklendi");
            }
            else
            {
                Console.WriteLine("personel Eklenmedi!!");
            }

        }
    }
}
