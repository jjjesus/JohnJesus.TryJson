using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace JohnJesus.TryJson.Model
{
    [DataContract]
    public class Person
    {
        [DataMember(Order=0)]
        public string Name { get; set; }

        [DataMember(Order=1)]
        public List<Address> AddressList { get; set; }
    }
}
