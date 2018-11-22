using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public List<string> ServeMethod()
        {
            return this._service.Serve();
        }
    }

    public class Product
    {

    }
}
