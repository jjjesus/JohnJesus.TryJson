using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using JohnJesus.TryJson.Model;

namespace JohnJesus.TryJson.User
{
    public class PersonFactory
    {
        public static Person createJohnJesus()
        {
            var person = new Person();

            var homeAddress = new Address("Home", "Plano, TX");
            var workAddress = new Address("Work", "Salt Mines, TX");
            person.AddressList = new List<Address> { homeAddress, workAddress };

            person.Name = "John Jesus";
            return person;
        }
        public static Person createGeorgeBush()
        {
            var person = new Person();

            var homeAddress = new Address("Home", "Dallas, TX");
            var workAddress = new Address("Work", "Washington DC");
            person.AddressList = new List<Address> { homeAddress, workAddress };

            person.Name = "George Bush";

            return person;
        }
        public static Person createFromJson(string jsonString)
        {
            MemoryStream memStream= new MemoryStream();
            StreamWriter writer = new StreamWriter(memStream);
            writer.AutoFlush = true;
            memStream.Position = 0;
            writer.Write(jsonString);

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
            memStream.Position = 0;
            Person person = (Person)ser.ReadObject(memStream);
            return person;
        }
    }
}
