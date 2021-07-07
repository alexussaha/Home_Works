using System;
using System.Linq;
using System.IO;
using System.Xml.Linq;

namespace fromCSVtoXML
{
    class Program
    {
        /// <summary>
        /// Программа превода CSV в XML
        /// </summary>
        /// <param name="csvFile">имя CSV файла</param>
        /// <param name="xmlFile">имя XML файла</param>
        static void Converter(string csvFile, string xmlFile)
        {
            string[] lines = File.ReadAllLines(csvFile);
            string[] headers = {"Name", "Surname", "University", "Faculty", "Department", "Age", "Course", "Group", "City", "default" };

            var xml = new XElement("Students",
               lines.Where((line, index) => index > 0).Select(line => new XElement("StudentIndo",
                  line.Split(';').Select((column, index) => new XElement(headers[index], column)))));

            xml.Save(xmlFile);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Начало...");
            Converter("..\\..\\students_4.csv", "..\\..\\students_8.xml");
            Console.WriteLine("Конец");
            Console.ReadKey();

        }
    }
}
