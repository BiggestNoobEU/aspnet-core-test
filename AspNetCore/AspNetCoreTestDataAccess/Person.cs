using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreTestDataAccess
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public bool IsMale { get; set; }
    }
}
