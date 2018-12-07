using System;
using Xunit;
using XUnitTestProject1;
using System.Collections.Generic;

namespace XUnitTestProject1
{

    public interface IService2
    {
        List<string> Serve();
    }

    public interface IService
    {
        List<Toothpaste> Serve();
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


    public class UnitTest1
    {

        public UnitTest1()
        {

        }


        public List<string> checkDIpatternInstance()
        { 

            Service2 s1 = new Service2();

            List<string> list = new List<string>();

            list = s1.Serve();

            return list;

        }

        public void checkToothpasteClassWorks()
        {

            Service1 s1 = new Service1();

            List<Toothpaste> list = new List<Toothpaste>();

            list = s1.Serve();

        }

        public void checkForToothpastePriceOver30()
        {

            Service1 s1 = new Service1();

            List<Toothpaste> list = new List<Toothpaste>();

            list = s1.Serve();

            foreach (Toothpaste el in list)
            {
                if (el.price > 30)
                {
                    Console.WriteLine("Toothpaste Cost over 30 SEK " + el.name);
                }
            }
         
        }

        public void checkClientCallWorksDIPattern()
        {
            Service1 s1 = new Service1();

            Client c1 = new Client(s1);

            c1.ServeMethod();

        }


        [Fact]
        public void Test1()
        {

            UnitTest1 t1 = new UnitTest1();

            Service2 s2 = new Service2();

            List<string> productlist_actual = new List<string>();

            productlist_actual = s2.Serve();

            ///////////////////////////////////////////////////////////

            Assert.NotSame(t1.checkDIpatternInstance(), productlist_actual);

        }

        [Fact]
        public void Test2()
        {

            checkToothpasteClassWorks();

        }

        [Fact]
        public void Test3()
        {

            checkForToothpastePriceOver30();

        }

        [Fact]
        public void Test4()
        {

            checkClientCallWorksDIPattern();

        }


    }
}
