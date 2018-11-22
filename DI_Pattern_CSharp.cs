



Implementation of Dependency Injection Pattern in C#

//////////////////////////////////

public interface IService {
 void Serve();
}
public class Service1 : IService {
 public void Serve() { Console.WriteLine("Service1 Called"); }
}
public class Service2 : IService {
 public void Serve() { Console.WriteLine("Service2 Called"); }
}
public class Client {
 private IService _service;
 public Client(IService service) {
 this._service = service;
 }
 public ServeMethod() { this._service.Serve(); }
}
class Program
{
 static void Main(string[] args)
 {
 //creating object
 Service1 s1 = new Service1(); 
 //passing dependency
 Client c1 = new Client(s1);
 //TO DO:
 
 Service2 s2 = new Service2(); 
 //passing dependency
 c1 = new Client(s2);
 //TO DO:
 }
}

//////////////////


public interface IService {
 void Serve();
}
public class Service1 : IService {
 public void Serve() { Console.WriteLine("Service1 Called"); }
}
public class Service2 : IService {
 public void Serve() { Console.WriteLine("Service2 Called"); }
}
public class Client {
 private IService _service;
 public IService Service {
 set { this._service = value; }
 }
 public ServeMethod() { this._service.Serve(); }
}
class Program
{
 static void Main(string[] args)
 {
 //creating object
 Service1 s1 = new Service1(); 
 
 Client client = new Client();
 client.Service = s1; //passing dependency
 //TO DO:
 
 Service2 s2 = new Service2(); 
 client.Service = s2; //passing dependency
 //TO DO:
 }
}


/////////////////


public interface IService {
 void Serve();
}
public class Service1 : IService {
 public void Serve() { Console.WriteLine("Service1 Called"); }
}
public class Service2 : IService {
 public void Serve() { Console.WriteLine("Service2 Called"); }
}
public class Client {
 private IService _service;
 public void Start(IService service) {
 service.Serve();
 }
}
class Program
{
 static void Main(string[] args)
 {
 //creating object
 Service1 s1 = new Service1(); 
 
 Client client = new Client(); 
 client.Start(s1); //passing dependency
 //TO DO:
 
 Service2 s2 = new Service2(); 
 client.Start(s2); //passing dependency
 }
}

///////////////////

Order System - Dental Office .... 

https://www.dotnettricks.com/learn/dependencyinjection/dependency-injection-in-aspnet-mvc-4-using-unity-ioc-container









