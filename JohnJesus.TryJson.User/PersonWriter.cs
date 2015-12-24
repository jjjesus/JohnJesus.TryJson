using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

using JohnJesus.TryJson.Model;


namespace JohnJesus.TryJson.User
{
    public class PersonWriter
    {
        public static string ToJson(Person person)
        {
            MemoryStream memStream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));

            ser.WriteObject(memStream, person);
            memStream.Position = 0;
            StreamReader sr = new StreamReader(memStream);
            return sr.ReadToEnd();
        }
    }
}
