using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.Goods
{
    public class PlayStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBundle { get; set; }
        public string Revision { get; set; }
        public string Color { get; set; }
        public string MemoryCapacity { get; set; }
        public double Price { get; set; }
    }
}
