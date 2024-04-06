using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Static__Extension
{
    internal class Person
    {
        private static int _id;
        public int Id { get; set; }
        public Person()
        {
            _id++;
            Id = _id;
        }
        public string FullName { get; set; }
        private sbyte _age;
        public sbyte Age
        {
            get { return _age; }
            set
            {
                if (_age > 0 && _age < 126)
                { _age = value; }
            }
        }
        public double Cash { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Fullname: {FullName}, Age: {Age}, Cash: {Cash}";
        }


    }
}
