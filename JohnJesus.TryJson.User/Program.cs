using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JohnJesus.TryJson.User
{
    class Program
    {
        static void Main(string[] args)
        {
            var jj = PersonFactory.createJohnJesus();
            var ww = PersonFactory.createGeorgeBush();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(PersonWriter.ToJson(jj));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(PersonWriter.ToJson(ww));
            Console.WriteLine(Environment.NewLine);

            StringBuilder sb = new StringBuilder();
            sb.Append(@"{""Name"":""Jeb Bush"",""AddressList"":[{""Name"":""Home"",""City"":""Miami, Florida""},{""Name"":""Work"",""City"":""Tampa, Florida""}]}");

            var jeb = PersonFactory.createFromJson(sb.ToString());
            Console.WriteLine(PersonWriter.ToJson(jeb));

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();
        }
    }
}
