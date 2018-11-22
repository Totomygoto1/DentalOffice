using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Implementation of Dependency Injection Pattern in C#

namespace DentalOffice.Models
{
   

    public interface IService
    {
        List<string> Serve();
    }

    public class Service1 : IService
    {
        List<string> Toothpaste = new List<string>();

        public List<string> Serve()
        {

            Toothpaste.Add("Pepsodent");
            Toothpaste.Add("Dentafrice");
            Toothpaste.Add("Colgate");

            foreach (string el in Toothpaste)
            {
                Console.WriteLine(el);
            }
            return Toothpaste;
        }
    }

    public class Service2 : IService
    {
        public List<string> Floss = new List<string>();

        public List<string> Serve()
        {
            Floss.Add("Menthol");
            Floss.Add("Aqua");
            Floss.Add("Frizzil");

            foreach (string el in Floss)
            {
                Console.WriteLine(el);
            }
            return Floss;
        }
    }


    public class Client
    {
        private IService _service;

        public Client(IService service)
        {
            this._service = service;
        }

        public void ServeMethod()
        {
            this._service.Serve();
        }
    }

    

    public class Product
    {

    }
}
