using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace JohnJesus.TryJson.Model
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string City { get; set; }

        public Address(string name, string street)
        {
            this.Name = name;
            this.City = street;
        }
    }
}
