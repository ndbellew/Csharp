using System;
using System.Collections.Generic;

/// This project is about the Snow Telemetry (SNOTEL) 
/// and Snow Course Data and Products 
/// http://www.wcc.nrcs.usda.gov/snow/
/// Also see SNOTEL Data Collection Network Fact Sheet 
/// http://www.wcc.nrcs.usda.gov/factpub/sntlfct1.html
/// 
/// The Natural Resources Conservation Service (NRCS)
/// wants to modernize the software system that collects
/// measurements at SNOTEL sites, communicates the measured
/// weather data to a central repository and produces report
/// of precipitation and other weather data.
/// 
/// As opposed to the current system of reports available
/// on the website for human-readable consumption, they
/// would like to create a service where automated applications
/// can pick up data directly.  (Later in the semester,
/// we'll refer to this as a web service - for now we'll just
/// refer to it as a service.
/// 
/// Your job is to design the software classes and methods 
/// that allow a weekly report to be requested by a method.
/// The SnotelConsumer console (below) will act as the requester,
/// the classes you design will provide the service.
/// 
/// This is a design project - you are not being asked to implement
/// the service methods.  You are being asked to design the classes; 
/// including their fields, properties, and methods that might provide
/// this service.  Methods will be empty except to return "dummy"
/// data of the specified type.
/// 
/// The SNOTEL system starts with sites deployed to mountainous isolated
/// locations where snow levels are to be measured.  Sites consist of
/// a thermometer, hygrometer, (meteor burst) radio, and battery.  The
/// automated system at the site will take regular temperature, humidity, snow level,
/// and snow moisture content readings.  When requested by radio they will
/// transmit weather data back to the central repository.  They will also
/// monitor the battery and the radio and report system health.
/// 
/// The SNOTEL central repository will maintain meta-data about each of the sites
/// including site id, lat, lon, elevation, and radio frequency.  The central
/// repository will request weather and system health data from each site
/// hourly.  
/// 
/// The SNOTEL central repository will respond to requests for data by aggregating
/// (summarizing) data in to hourly reports by site and will also summarize 
/// hourly data into daily reports.  Hourly reports include Snow Water 
/// Equivalent, Snow Depth, Preciption Accumulation, and Air Tempurature.  Consumers
/// can also request site meta-data.
/// 
/// Finally, the SNOTEL central repository will monitor site system health 
/// reports, and if necessary, will dispatch a maintenance crew for repair.
/// 
/// Again, your job is to design the namespaces, classes, fields, properties, 
/// and methods for this system.  You are not asked to implement the methods 
/// (except to return "dummy" data).  This project is about 
/// good object oriented design.
/// 
/// Pay particular attention to the Pillars of OOPS - encapsulation, abstraction,
/// and inheritance.  We've just covered accessibility of members and this can be used 
/// to incorporate these principles into your design.
/// 
/// After grading, we will do an in-class design review of several  
/// projects - so make sure your design is understandable 
/// to both me and the rest of the class.

namespace SnotelServiceDesign
{
    class SnotelConsumer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What are the conditions at your favority ski area?");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}