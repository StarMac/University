using System;
using System.Collections.Generic;
using System.Text;

namespace SharpWasher
{
    class Car
    {
        public string name { get; set; }
        public bool clean { get; set; }

        public Car(string name)
        {
            this.name = name;
            this.clean = false;
        }

        public override string ToString()
        {
            return name + " " + clean;
        }
    }
}
