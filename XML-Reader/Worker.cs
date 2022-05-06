using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Reader
{
    class Worker
    {
        public string Name { get; private set; }
        public int  Age { get; private set; }
        public bool Programmer { get; private set; }
        public Worker(string name, int age, bool programmer)
        {
            Name = name;
            Age = age;
            Programmer = programmer;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
