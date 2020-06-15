using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Contents { get; set; }
        public string Type { get; set; }

        public BaseDisc(string name, int capacity, string contents, string type)
        {
            Name = name;
            Capacity = capacity;
            Contents = contents;
            Type = type;
        }

        public abstract void ReportInfo();
    }
}
