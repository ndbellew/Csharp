using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Notes about Web services, 
/// Service Oriented Architecture (SOA), and
/// Component Architecture.
/// 
/// It all starts with Remote Procedure Calls (RPC).
/// Remote procedure call - https://en.wikipedia.org/wiki/Remote_procedure_call
/// CORBA and SOAP Web Services are a follow-on from RPC.
/// WCF is a generalized form of RPC and web services.
/// 
/// We going to do a walk-through building a 
/// Windows Communication Foundation (WCF) web service.
/// (Some of this is from Developing Service-Oriented Applications with WCF
/// https://msdn.microsoft.com/en-us/library/hh156544%28v=vs.110%29.aspx).
/// 
/// Start a C# Windows Console App named something like
/// WebService1.
/// After your console app is created, find the WebService1
/// project in Solution Explorer.  Right-click and rename it
/// something like WebServiceConsumer.
/// Find the Program.cs file in your console app project
/// and rename it WebServiceConsumer also (select to rename 
/// all references as well).
/// Go back to Solution Explorer and select and 
/// right-click Solution WebService1.  Select Add New Project,
/// then select WCF, then select WCF Service Application.
/// 
/// Debug the WcfService1 project - this will bring up
/// a web page where you can find the WSDL (open Service1.svc 
/// from the browser window).  The WSDL is the contract
/// between the provider and the consumer.
/// 
/// Go back to WebServiceConsumer project, right-click References,
/// Add Service Reference.  In the Service Reference dialog select
/// Discover Services in Solution and you should be able to find
/// your WcfService1 service - select it and click Ok.  You
/// should now find a Service Reference in the WebServiceConsumer
/// console app.
/// 
/// Add code to your console, similar to the following, to 
/// use your web service:
/// 
///             ServiceReference1.Service1Client s1c = new ServiceReference1.Service1Client();
///             string response = s1c.GetData(42);
///             Console.WriteLine(response);
///             slc.Close();
/// 
/// Put a break-point in your console app and a break-point 
/// in your web service implementation code and follow
/// what happens (the web service project will have to be
/// started first).
/// 
namespace WebService1
{
    class WebServiceConsumer
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client s1c = new ServiceReference1.Service1Client();
            string response = s1c.GetData(42);
             Console.WriteLine(response);

            ServiceReference1.CompositeType ctIn, ctOut;
            ctIn = new ServiceReference1.CompositeType();
            ctIn.StringValue = "Hello";
            ctIn.BoolValue = true;

            ctOut = s1c.GetDataUsingDataContract(ctIn); 
             s1c.Close();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}