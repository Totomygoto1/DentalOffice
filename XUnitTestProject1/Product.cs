using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Implementation of Dependency Injection Pattern in C#

namespace DentalOffice.Models
{

    public interface IToothPaste
    {
        void showNameAndPrice();
    }

    public class Toothpaste : IToothPaste
    {
        public string name;
        public decimal price;

        public Toothpaste(string n, decimal p)
        {
            this.name = n;
            this.price = p;
        }

        public void showNameAndPrice()
        {
            Console.WriteLine(this.name + " " + this.price);
        }


    }

    public interface IService
    {
        List<Toothpaste> Serve();
    }

    public interface IService2
    {
        List<string> Serve();
    }

    public class Service1 : IService
    {
        List<Toothpaste> Toothpaste = new List<Toothpaste>();

        public List<Toothpaste> Serve()
        {
            Toothpaste t1 = new Toothpaste("Sensodyne", 19);
            Toothpaste t2 = new Toothpaste("SimlpyWhite", 29);
            Toothpaste t3 = new Toothpaste("Aim", 39);

            Toothpaste.Add(t1);
            Toothpaste.Add(t2);
            Toothpaste.Add(t3);

            foreach (Toothpaste el in Toothpaste)
            {
                Console.WriteLine(el);
            }
            return Toothpaste;
        }
    }

    public class Service2 : IService2
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
