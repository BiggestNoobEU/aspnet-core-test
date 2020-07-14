using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreTestDataAccess
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public int StreetNr { get; set; }
        public List<Person> Person { get; set; }
    }
}
