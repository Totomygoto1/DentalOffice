using System;
using Xunit;
using XUnitTestProject1;
using System.Collections.Generic;

namespace XUnitTestProject1
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


    public class UnitTest1
    {

        public UnitTest1()
        {

        }


        public List<string> checkDIpatternInstance()
        { 

            Service1 s1 = new Service1();

            List<string> list = new List<string>();

            list = s1.Serve();

            return list;

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

            UnitTest1 t2 = new UnitTest1();

            Service1 s1 = new Service1();

            List<string> list_a = new List<string>();

            list_a = s1.Serve();

            ///////////////////////////////////////////////////////////

            Assert.NotSame(t2.checkDIpatternInstance(), list_a);

        }

    }
}
