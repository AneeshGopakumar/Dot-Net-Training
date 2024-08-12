using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace Day_14
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main2(string[] args)
        {
            var directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent;
            var filePath = directory + "\\csvfiles\\books.csv";

            List<Person> peopleList = new List<Person>
            {
                new Person{FirstName="ABC",LastName="XYZ",Age=20},
                new Person{FirstName="DEF",LastName="UVW",Age=30}
            };

            using var writer = new StreamWriter(filePath);
            using var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));
            {
                csv.WriteRecords(peopleList);
            }

        }
    }
}
