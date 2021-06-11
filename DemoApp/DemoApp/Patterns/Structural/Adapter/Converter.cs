using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DemoApp.Patterns.Structural.Adapter
{
    //https://code-maze.com/adapter/
    public class Patient
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Year { get; set; }
    }

    public static class PatientDataProvider
    {
        public static List<Patient> GetData() =>
           new List<Patient>
           {
            new Patient { City = "Italy", Name = "Alfa Romeo", Year = 2016 },
            new Patient { City = "UK", Name = "Aston Martin", Year = 2018 },
            new Patient { City = "USA", Name = "Dodge", Year = 2017 },
            new Patient { City = "Japan", Name = "Subaru", Year = 2016 },
            new Patient { City = "Germany", Name = "BMW", Year = 2015 }
           };
    }

    public class XmlConverter
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Patients");
            var xAttributes = PatientDataProvider.GetData()
                .Select(m => new XElement("Patient",
                                    new XAttribute("City", m.City),
                                    new XAttribute("Name", m.Name),
                                    new XAttribute("Year", m.Year)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }

    public class JsonConverter
    {
        private IEnumerable<Patient> _manufacturers;

        public JsonConverter(IEnumerable<Patient> manufacturers)
        {
            _manufacturers = manufacturers;
        }

        public void ConvertToJson()
        {
            var jsonManufacturers = JsonConvert.SerializeObject(_manufacturers, Formatting.Indented);

            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonManufacturers);
        }
    }

    public interface IXmlToJson
    {
        void ConvertXmlToJson();
    }

    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly XmlConverter _xmlConverter;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public void ConvertXmlToJson()
        {
            var patients = _xmlConverter.GetXML()
                    .Element("Patients")
                    .Elements("Patient")
                    .Select(m => new Patient
                    {
                        City = m.Attribute("City").Value,
                        Name = m.Attribute("Name").Value,
                        Year = Convert.ToInt32(m.Attribute("Year").Value)
                    });

            new JsonConverter(patients)
                .ConvertToJson();
        }
    }
}